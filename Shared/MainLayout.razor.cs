﻿using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Linq;

namespace BlazorApp.Shared
{
    public partial class MainLayout
    {
        [Inject] protected IEnvironmentInfo EnvironmentInfo { get; set; }
        readonly Guid _uniqueId = Guid.NewGuid();
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        //protected sealed override void BuildRenderTree(RenderTreeBuilder builder)
        //{
        //    builder.AddContent(0, BeforeBuildRenderTree);
        //}
        protected virtual void BeforeBuildRenderTree(RenderTreeBuilder builder)
        {
            EnvironmentInfo.RenderScriptLoader(builder, _uniqueId);
            builder.CloseComponent();
        }
    }
}