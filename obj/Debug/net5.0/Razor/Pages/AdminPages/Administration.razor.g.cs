#pragma checksum "D:\repos\DMM\Pages\AdminPages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d86903ffba50ffeab6f5c7557bf8b7b830b676a"
// <auto-generated/>
#pragma warning disable 1591
namespace DMM.Pages.AdminPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\DMM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\DMM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\DMM\_Imports.razor"
using DMM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\DMM\_Imports.razor"
using DMM.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\DMM\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\DMM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\DMM\Pages\AdminPages\Administration.razor"
using Blazority;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "<div style=\"width:100%;min-height:60px;border-bottom: 2px solid darkred;\"><div style=\"float:left;height:40px;width:90%;min-width:600px;\"><h1 style=\"font-weight:bold;margin:0 auto\">Administration</h1></div></div>\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "width:100%;height:60px;border-bottom: 2px solid darkred;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "float:right;");
            __builder.AddMarkupContent(6, "<label for=\"uploadFiles\">Select File(s)</label>\r\n            ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(7);
            __builder.AddAttribute(8, "id", "uploadFiles");
            __builder.AddAttribute(9, "multiple", true);
            __builder.AddAttribute(10, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 15 "D:\repos\DMM\Pages\AdminPages\Administration.razor"
                                                                           HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
