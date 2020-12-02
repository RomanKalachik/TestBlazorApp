using DevExpress.Blazor.Internal;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace BlazorApp.Shared
{
    public partial class MainLayout
    {
        [Inject] protected IEnvironmentInfo EnvironmentInfo { get; set; }
    }
}