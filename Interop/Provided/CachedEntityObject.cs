using Microsoft.JSInterop;
using Microsoft.JSInterop.WebAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//TODO refactor this ex EventHorizon.Blazor.Interop
namespace DevExpress.Blazor.Interop.Internal
{
    [JsonConverter(typeof(CachedEntityConverter<CachedEntity>))]
    class CachedEntity : ICachedEntity
    {
        /// <inheritdoc />
        public string ___guid { get; set; }
    }

    class CachedEntityConverter<T>
      : JsonConverter<T> where T : CachedEntity
    {
        /// <inheritdoc />
        public override bool CanConvert(Type typeToConvert) =>
            typeof(T).IsAssignableFrom(typeToConvert);
        /// <inheritdoc />
        public override T Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            T entity = (T)Activator.CreateInstance(typeToConvert);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return entity;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "___guid":
                            entity.___guid = reader.GetString();
                            break;
                    }
                }
            }
            throw new JsonException("___guid was not found");
        }
        /// <inheritdoc />
        public override void Write(
            Utf8JsonWriter writer,
            T value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStartObject();
            writer.WriteString("___guid", value.___guid);
         //   IEnumerable<Tuple<string, object>> values =
         //          (from property in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
         //           where property.CanRead &&
         //property.CanWrite
         //           select new Tuple<string, object>(property.Name,
         //                              property.GetValue(value)));
         //   foreach (var val in values)
         //       writer.WriteString(val.Item1, val.Item2.ToString());
            writer.WriteEndObject();
        }
    }

    class CachedEntityObject : CachedEntity
    {
        protected static readonly IDictionary<string, ICachedEntity> CachedEntityMap = new Dictionary<string, ICachedEntity>();
        protected IDictionary<string, ICachedEntity> _cachedEntityMap = new Dictionary<string, ICachedEntity>();
        protected readonly DotNetObjectReference<CachedEntityObject> _invokableReference;
        public CachedEntityObject()
        {
            _invokableReference = DotNetObjectReference.Create(
                this
            );
        }
        public CachedEntityObject(
            ICachedEntity entity
        )
        {
            ___guid = entity.___guid;
            _invokableReference = DotNetObjectReference.Create(
                this
            );
        }
    }

    static class EventHorizonBlazorInterop
    {
        /// <summary>
        /// This will call the identifier, from window, and attached a callback function to it.
        /// <br />
        /// <br />
        /// Does NOT take into account the identifier could be an CachedEntity.
        /// <br />
        /// <br />
        /// Identifier: A '.' separated string of identifiers.
        /// 
        /// </summary>
        /// <param name="identifier">The location on window that should be called.</param>
        /// <param name="assemblyName">This should be the dll assembly name that the referenceCallback is located.</param>
        /// <param name="referenceCallback">The method that should be called when the identifier callback is triggered.</param>
        /// <returns>This method is async.</returns>
        public static ValueTask AssemblyFuncCallback(
            string identifier,
            string assemblyName,
            string referenceCallback
        )
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.assemblyFuncCallback",
                identifier,
                assemblyName,
                referenceCallback
            );
        }
        /// <summary>
        /// This takes in a <see cref="ICachedEntity.___guid"/> and property adding the returned value into the cache on the client.
        /// 
        /// </summary>
        /// <param name="identifier">The <see cref="ICachedEntity.___guid"/> on the client.</param>
        /// <param name="prop">The property on the root the value should be from.</param>
        /// <returns>The cache identifier of the prop value.</returns>
        public static ICachedEntity cacheEntity(
            string identifier,
            string prop
        )
        {
            return RUNTIME.Invoke<CachedEntity>(
                "blazorInterop.cacheEntity",
                identifier,
                prop
            );
        }
        /// <summary>
        /// Call a specific function on ICachedEntity implementation.
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.Call(
        ///     this, /* ICachedEntity */ 
        ///     "attachControl", /* Function Name/Key */
        ///     arguments[1...n]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Call(
            params object[] args
        )
        {
            RUNTIME.InvokeVoid(
                "blazorInterop.call",
                args
            );
        }
        /// <summary>
        /// This will call a function on a passed in identifier, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Primitive
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.Func<string>(
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive type should be returned.</typeparam>
        /// <param name="args">The identifier and any arguments to passed in function all.</param>
        /// <returns>The result of the function call.</returns>
        public static T Func<T>(
            params object[] args
        )
        {
            return RUNTIME.Invoke<T>(
                "blazorInterop.func",
                args
            );
        }
        /// <summary>
        /// This will call a function on a passed in identifier, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Primitives
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.FuncArray<string>(
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive type the array should be returned as.</typeparam>
        /// <param name="args">The identifier and any arguments to passed in function all.</param>
        /// <returns>The primitive array result of the function call.</returns>
        public static T[] FuncArray<T>(
            params object[] args
        )
        {
            return RUNTIME.Invoke<T[]>(
                "blazorInterop.funcArray",
                args
            );
        }
        /// <summary>
        /// This will call a function on a passed in identifier, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Classes
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
        ///     entity => new Vector3(entity),
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">The type of the Class the array should return.</typeparam>
        /// <param name="classBuilder">Used to build the Classes in the Array, passes in CachedEntity from client.</param>
        /// <param name="args">The identifier and any arguments to passed in function all.</param>
        /// <returns>The Class array result of the function call.</returns>
        public static T[] FuncArrayClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            string[] results = RUNTIME.Invoke<string[]>(
                "blazorInterop.funcArrayClass",
                args
            );
            T[] array = new T[results.Length];
            int index = 0;
            foreach (string result in results)
            {
                array[index] = classBuilder(new CachedEntity { ___guid = result });
                index++;
            }

            return array;
        }
        /// <summary>
        /// This will call the passed in property funcCallbackName on the entity with a callback function.
        /// <br />
        /// On callback calls it will cache the objects and pass them through the CachedEntityConverter to marshal the arguments.
        /// 
        /// </summary>
        /// <typeparam name="T">The type of class creating the callback.</typeparam>
        /// <param name="entity">The entity this callback should be attached to.</param>
        /// <param name="funcCallbackName">The name of the function that the callback will be passed to.</param>
        /// <param name="referenceMethod">The method that should be called on the invokableReference during the callback trigger.</param>
        /// <param name="invokableReference">The reference object that the referenceMethod should call on.</param>
        /// <returns>This method is async.</returns>
        public static ValueTask FuncCallback<T>(
            ICachedEntity entity,
            string funcCallbackName,
            string referenceMethod,
            DotNetObjectReference<T> invokableReference
        ) where T : class
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.funcCallback",
                entity.___guid,
                funcCallbackName,
                referenceMethod,
                invokableReference
            );
        }
        /// <summary>
        /// This will call a function on a passed in identifier, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Class
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.FuncClass<Vector3>(
        ///     entity => new Vector3(entity),
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">The type of class to response with.</typeparam>
        /// <param name="classBuilder">The builder used to create a class from, passes in CachedEntity from client.</param>
        /// <param name="args">The identifier and any arguments to passed in function all.</param>
        /// <returns>The result from classBuilder.</returns>
        public static T FuncClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            string cacheKey = RUNTIME.Invoke<string>(
                "blazorInterop.funcClass",
                args
            );
            return classBuilder(new CachedEntity { ___guid = cacheKey });
        }
        /// <summary>
        /// This will return a primitive property value, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Primitive
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.Get<Vector3>(
        ///     entity => new Vector3(entity),
        ///     "document.createElement"
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive type the result should be.</typeparam>
        /// <param name="root">Property name from window or ICachedEntity.___guid.</param>
        /// <param name="prop">Property to retrieve from root.</param>
        /// <returns>The primitive typed property from root.</returns>
        public static T Get<T>(
            string root,
            string prop
        )
        {
            string result = (RUNTIME).InvokeUnmarshalled<ValueTuple<string, string>, string>(
                "blazorInterop.get",
                ValueTuple.Create(
                    root,
                    prop
                )
            );
            if (result == null)
            {
                return default;
            }
            return (T)Convert.ChangeType(
                result,
                Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T)
            );
        }
        /// <summary>
        /// This will return a primitive array property value, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Primitives
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.GetArray<string>(
        ///     playerCachedEntity.___guid,
        ///     "tags"
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive type the array result should be.</typeparam>
        /// <param name="root">Property name from window or ICachedEntity.___guid.</param>
        /// <param name="prop">Property to retrieve from root.</param>
        /// <returns>The primitive typed array property from root.</returns>
        public static T[] GetArray<T>(
            string root,
            string prop
        )
        {
            return RUNTIME.Invoke<T[]>(
                "blazorInterop.getArraySlow",
                root,
                prop
            );
        }
        /// <summary>
        /// This will return a class array property value, root starts at window.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Primitives
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.GetArrayClass<Vector3>(
        ///     npcCachedEntity.___guid,
        ///     "pathToPlayer"
        ///     entity => new Vector3(entity),
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Class type the array result should be.</typeparam>
        /// <param name="root">Property name from window or ICachedEntity.___guid.</param>
        /// <param name="prop">Property to retrieve from root.</param>
        /// <param name="classBuilder">Used to build the Class, passes in CachedEntity from client.</param>
        /// <returns>The Class typed array property from root.</returns>
        public static T[] GetArrayClass<T>(
            string root,
            string prop,
            Func<ICachedEntity, T> classBuilder
        )
        {
            string[] results = RUNTIME.Invoke<string[]>(
                "blazorInterop.getArrayClassSlow",
                root,
                prop
            );
            T[] array = new T[results.Length];
            int index = 0;
            foreach (string result in results)
            {
                array[index] = classBuilder(new CachedEntity { ___guid = result });
                index++;
            }

            return array;
        }
        /// <summary>
        /// This will return a Class property value, root starts at window.
        /// <br />
        /// On classBuilder call it will pass in the cached entity from the response.
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Class
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.GetClass<Vector3>(
        ///     playerCachedEntity.___guid,
        ///     "position"
        ///     entity => new Vector3(entity),
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Class type the result should be.</typeparam>
        /// <param name="root">Property name from window or ICachedEntity.___guid.</param>
        /// <param name="prop">Property to retrieve from root.</param>
        /// <param name="classBuilder">Used to build the Class, passes in CachedEntity from client.</param>
        /// <returns>The class typed property from root.</returns>
        public static T GetClass<T>(
            string root,
            string prop,
            Func<ICachedEntity, T> classBuilder
        )
        {
            string result = RUNTIME.InvokeUnmarshalled<ValueTuple<string, string>, string>(
                "blazorInterop.getClass",
                ValueTuple.Create(
                    root,
                    prop
                )
            );

            return classBuilder(new CachedEntity { ___guid = result });
        }
        /// <summary>
        /// This will call 'new' on the class/function identifier passed in, root starts at window.
        /// <br />
        /// <br />
        /// Identifier: A '.' separated string of identifiers .
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.New(
        ///     "BABYLON.Vector3",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// 
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.New(
        ///     "BABYLON.Vector3",
        ///     1,
        ///     2,
        ///     3
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <param name="args">The identifier and any arguments to pass into constructor.</param>
        /// <returns>Client side cached entity created on client.</returns>
        public static ICachedEntity New(
            params object[] args
        )
        {
            return RUNTIME.Invoke<CachedEntity>(
                "blazorInterop.new",
                args
            );
        }
        /// <summary>
        /// Create a JavaScript "Function" on the client based on the script, cached based on methodName.
        /// <br />
        /// <br />
        /// Scripts are cached client-side, so they are not built every time it is called.
        /// <br />
        /// Arguments can be passed to script, they can be accessed from the script body using '$args'.
        /// 
        /// </summary>
        /// <param name="methodName">The name of the method, used for caching.</param>
        /// <param name="script">The valid JavaScript that should be used to create the script.</param>
        /// <param name="args">The JSON object to be passed into the script when called.</param>
        /// <returns>Allows for Async running</returns>
        public static ValueTask RunScript(
            string methodName,
            string script,
            object args
        )
        {
            return JSRuntime.InvokeVoidAsync(
                "blazorInterop.runScript",
                new JavaScriptMethodRunner
                {
                    MethodName = methodName,
                    Script = script,
                    Args = args
                }
            );
        }
        /// <summary>
        /// This will take the value and set it on the root property. 
        /// 
        /// </summary>
        /// <param name="root">Property name from window or <see cref="ICachedEntity.___guid"/>.</param>
        /// <param name="identifier">The property from root that the value should be set on.</param>
        /// <param name="value">The value that should be set on the root identifier property.</param>
        public static void Set(
            string root,
            string identifier,
            object value
        )
        {
            JSRuntime.InvokeVoidAsync(
                "blazorInterop.set",
                root,
                identifier,
                value
            );
        }
        /// <summary>
        /// This will call a promise based on the identifier, returning a primitive.
        /// <br />
        /// Root starts at 'window'
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Primitive
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.Task<string>(
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive Type of Result.</typeparam>
        /// <param name="args">The identifier and any arguments to passed into Promise function.</param>
        /// <returns>The result of the Promise call.</returns>
        public static ValueTask<T> Task<T>(
            params object[] args
        )
        {
            return RUNTIME.InvokeAsync<T>(
                "blazorInterop.task",
                args
            );
        }
        /// <summary>
        /// This will call a promise based on the identifier, returning an Array of Primitives.
        /// <br />
        /// Root starts at 'window'
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Primitives
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.TaskArray<string>(
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Primitive Type of Result.</typeparam>
        /// <param name="args">The identifier and any arguments to passed into the Promise function call.</param>
        /// <returns>The Array result of the Promise call.</returns>
        public static ValueTask<T[]> TaskArray<T>(
            params object[] args
        )
        {
            return RUNTIME.InvokeAsync<T[]>(
                "blazorInterop.taskArray",
                args
            );
        }
        /// <summary>
        /// This will call a promise based on the identifier, returning an Array of Classes.
        /// <br />
        /// Root starts at 'window'
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Array of Classes
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.FuncArrayClass<Vector3>(
        ///     entity => new Vector3(entity),
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Class Type of Result.</typeparam>
        /// <param name="classBuilder">Used to build the Classes in the Array, passes in CachedEntity from client.</param>
        /// <param name="args">The identifier and any arguments to passed into the Promise function call.</param>
        /// <returns>The Class Array result of the Promise call.</returns>
        public static async ValueTask<T[]> TaskArrayClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            string[] results = await RUNTIME.InvokeAsync<string[]>(
                "blazorInterop.taskArrayClass",
                args
            );
            T[] array = new T[results.Length];
            int index = 0;
            foreach (string result in results)
            {
                array[index] = classBuilder(new CachedEntity { ___guid = result });
                index++;
            }

            return array;
        }
        /// <summary>
        /// This will call a promise based on the identifier, returning a Class.
        /// <br />
        /// Root starts at 'window'
        /// <br />
        /// <br />
        /// Identifier can be <see cref="ICachedEntity.___guid"/>
        /// <br />
        /// Support: Class
        /// 
        /// <example>
        /// <code>
        /// <![CDATA[
        /// EventHorizonBlazorInterop.TaskClass<Vector3>(
        ///     entity => new Vector3(entity),
        ///     "document.createElement",
        ///     [n...arguments]
        /// );
        /// ]]>
        /// </code>
        /// </example>
        /// 
        /// </summary>
        /// <typeparam name="T">Class Type of Result.</typeparam>
        /// <param name="classBuilder">The builder used to create a class from, passes in CachedEntity from client.</param>
        /// <param name="args">The identifier and any arguments to passed in Promise function call.</param>
        /// <returns>The result of the Promise call.</returns>
        public static async ValueTask<T> TaskClass<T>(
            Func<ICachedEntity, T> classBuilder,
            params object[] args
        )
        {
            string cacheKey = await RUNTIME.InvokeAsync<string>(
                "blazorInterop.taskClass",
                args
            );
            return classBuilder(new CachedEntity { ___guid = cacheKey });
        }
        /// <summary>
        /// This is used to access the Client from .NET.
        /// </summary>
        public static IJSRuntime JSRuntime { get; set; }
        /// <summary>
        /// This is the WebAssemblyJSRuntime cast from JSRuntime.
        /// This provides very low level, not supported API that allow for high performances calls to the WASM layer.
        /// </summary>
        public static WebAssemblyJSRuntime RUNTIME => JSRuntime as WebAssemblyJSRuntime;
    }
    struct JavaScriptMethodRunner
    {
        public object Args { get; set; }
        public string MethodName { get; set; }
        public string Script { get; set; }
    }
    interface ICachedEntity
    {
        string ___guid { get; set; }
    }
}
namespace DevExpress.Blazor.Interop.Internal.Callbacks
{
}

