#pragma checksum "C:\Users\Erik\source\repos\DMM\Pages\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00557ee9ccf77a51fd986e15a62c93d307e8589e"
// <auto-generated/>
#pragma warning disable 1591
namespace DMM.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using DMM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using DMM.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddAttribute(2, "b-no0o7p30qk");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "background-color:#3B3432;width:100%;height:60px;border-bottom: 4px solid darkred;");
            __builder.AddAttribute(5, "b-no0o7p30qk");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "float:left;");
            __builder.AddAttribute(8, "b-no0o7p30qk");
            __builder.OpenComponent<DMM.Pages.Shared.CollectionsDropDown>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "float:left;");
            __builder.AddAttribute(13, "b-no0o7p30qk");
            __builder.OpenComponent<DMM.Pages.Shared.CommunityDropDown>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "float:right;");
            __builder.AddAttribute(18, "b-no0o7p30qk");
            __builder.OpenComponent<DMM.Pages.Shared.LoginDisplay>(19);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "content px-4");
            __builder.AddAttribute(23, "b-no0o7p30qk");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\Users\Erik\source\repos\DMM\Pages\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
