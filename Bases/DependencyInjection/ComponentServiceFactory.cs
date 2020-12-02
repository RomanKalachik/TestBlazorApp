using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Components;

namespace DevExpress.Blazor.Internal.Services {

    [AttributeUsageAttribute(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DxInjectAttribute : Attribute { }

    public interface IComponentServiceFactory : IComponentService {
        T Create<T>(params object[] constructorArgs) where T : IComponentService;
        T Create<T, TArg>(in TArg arg) where T : IComponentService;
        void ResolveDependencies(object target);
    }
}
namespace DevExpress.Blazor.Internal {
    using DevExpress.Blazor.Internal.Services;
    public class ComponentServiceFactory : IComponentServiceFactory {
        static readonly  BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
      
        protected delegate IComponentService CreateDelegate(IComponentServiceProvider serviceProvider, object[] args);
        protected delegate void ResolveDelegate(object target, IComponentServiceProvider serviceProvider);

        protected static ConcurrentDictionary<Type, CreateDelegate> CachedCreateDelegates { get; }
        protected static ConcurrentDictionary<Type, ResolveDelegate> CachedResolveDelegates { get; }
        protected static ConcurrentDictionary<Type, PropertyInfo[]> CachedPropertyInfoLookups { get; }

        static ComponentServiceFactory() {
            CachedCreateDelegates = new ConcurrentDictionary<Type, CreateDelegate>();
            CachedResolveDelegates = new ConcurrentDictionary<Type, ResolveDelegate>();
            CachedPropertyInfoLookups = new ConcurrentDictionary<Type, PropertyInfo[]>();
        }

        protected IComponentServiceProvider ServiceProvider { get; }

        public ComponentServiceFactory(IComponentServiceProvider serviceProvider) {
            ServiceProvider = serviceProvider;
        }
        public T Create<T>(params object[] constructorArgs) where T : IComponentService {
            return (T)(GetCreateDelegate(typeof(T), constructorArgs)(ServiceProvider, constructorArgs));
        }

        public T Create<T, TArg>(in TArg arg) where T : IComponentService
            => Create<T>(arg);
        public void ResolveDependencies(object target) {
            GetResolveDelegate(target.GetType()).Invoke(target, ServiceProvider);
        }
        static CreateDelegate GetCreateDelegate(Type type, object[] arguments) {
            return GetCachedItem(type, CachedCreateDelegates, CreateBuilder, arguments.Length);
        }
        static ResolveDelegate GetResolveDelegate(Type type) {
            return GetCachedItem(type, CachedResolveDelegates, CreateResolver);
         }

        static T GetCachedItem<T>(Type t, ConcurrentDictionary<Type, T> cache, Func<Type, T> delegateBuilder) {
            return cache.GetOrAdd(t, delegateBuilder);
        }

        static T GetCachedItem<T, TArg>(Type t, ConcurrentDictionary<Type, T> cache, Func<Type, TArg, T> delegateBuilder, TArg
        arg = default) {
            return cache.GetOrAdd(t, delegateBuilder, arg);
        }
        static ResolveDelegate CreateResolver(Type t) {
            var propertiesToSet = FindAllInjectableProperties(t);

            ParameterExpression serviceArg = Expression.Parameter(typeof(object), "service");
            ParameterExpression spArg = Expression.Parameter(typeof(IComponentServiceProvider), "sp");
            //ParameterExpression rsArg = Expression.Parameter(typeof(ICollection<object>), "sp");
            var defineResult = Expression.Variable(t, "result");

            List<Expression> funcBody = new List<Expression>();
            funcBody.Add(defineResult);
            funcBody.Add(Expression.Assign(defineResult, Expression.Convert(serviceArg, t)));
            foreach(var p in propertiesToSet) {
                var propExpr = Expression.Property(defineResult, p);
                var invokeSpExpr = Expression.Call(spArg, "GetService", new Type[] { p.PropertyType });
                funcBody.Add(Expression.Assign(propExpr, Expression.Convert(invokeSpExpr, p.PropertyType)));
            }
            var lambdaParams = new List<ParameterExpression>() { serviceArg, spArg };
            var body = Expression.Block(new ParameterExpression[] { defineResult }, funcBody);
            var func = Expression.Lambda<ResolveDelegate>(body, lambdaParams);
            return func.Compile();
        }

        static PropertyInfo[] FindAllInjectableProperties(Type t) {
            return FindIn(t);

            static PropertyInfo[] FindIn(Type t) => t == null ? Array.Empty<PropertyInfo>() : GetCachedItem(t, CachedPropertyInfoLookups, FindInExtended, t.BaseType);
            static PropertyInfo[] FindInExtended(Type t, Type baseType) => FindIn(baseType).Concat(FindProperties(t)).ToArray();
            static IEnumerable<PropertyInfo> FindProperties(Type t) {
                var propertiesToSet = t.GetProperties(bindingFlags);
                for(int i = 0; i < propertiesToSet.Length; i++) {
                    var propertyInfo = propertiesToSet[i];
                    if(propertyInfo.CanWrite && CanBeInjected(propertyInfo))
                        yield return propertyInfo;
                }
            }
        }

        static bool CanBeInjected(PropertyInfo x) =>
            x.DeclaringType == x.ReflectedType &&
            x.GetCustomAttribute<DxInjectAttribute>(true) != null ||
            (false && x.GetCustomAttribute<InjectAttribute>(true) != null);

        static CreateDelegate CreateBuilder(Type t, int argsCount) {
            var constructroInfo = t.GetConstructors().First(x => x.GetParameters().Length == argsCount);
            var propertiesToSet = FindAllInjectableProperties(t);


            ParameterExpression spArg = Expression.Parameter(typeof(IComponentServiceProvider), "sp");
            ParameterExpression argsParam = Expression.Parameter(typeof(object[]), "args");
            var defineResult = Expression.Variable(t, "result");

            var parameters = constructroInfo.GetParameters();
            var constrParams = new List<Expression>();
            for(int i = 0; i < parameters.Length; i++) {
                var parameter = parameters[i];
                var argsByIndex = Expression.ArrayAccess(argsParam, Expression.Constant(i, typeof(int)));
                constrParams.Add(Expression.Convert(argsByIndex, parameter.ParameterType));
            }
            var newConstr = Expression.New(constructroInfo, constrParams);
            List<Expression> funcBody = new List<Expression>();
            funcBody.Add(defineResult);
            funcBody.Add(Expression.Assign(defineResult, newConstr));
            foreach(var p in propertiesToSet) {
                var propExpr = Expression.Property(defineResult, p);
                var invokeSpExpr = Expression.Call(spArg, "GetService", new Type[] { p.PropertyType });
                funcBody.Add(Expression.Assign(propExpr, Expression.Convert(invokeSpExpr, p.PropertyType)));
            }
            Type cs = typeof(IComponentService);
            funcBody.Add(Expression.Call(Expression.Convert(defineResult, cs), cs.GetMethod("AfterDependenciesResolved")));
            LabelTarget returnTarget = Expression.Label(typeof(IComponentService));
            funcBody.Add(Expression.Return(returnTarget, defineResult));
            funcBody.Add(Expression.Label(returnTarget, Expression.Constant(null, typeof(IComponentService))));
            var paramsIEnum = new List<ParameterExpression>() { spArg, argsParam };
            var body = Expression.Block(typeof(IComponentService), new ParameterExpression[] { defineResult }, funcBody);
            var func = Expression.Lambda<CreateDelegate>(body, paramsIEnum);
            return func.Compile();
        }

        void IComponentService.AfterDependenciesResolved() { }
    }

  
}
