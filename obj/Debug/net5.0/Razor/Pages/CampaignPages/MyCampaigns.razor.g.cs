#pragma checksum "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f884a145a08ed2ff07f74e8bd369e0dae54d5e6c"
// <auto-generated/>
#pragma warning disable 1591
namespace DMM.Pages.CampaignPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\dmm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\dmm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\dmm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\dmm\_Imports.razor"
using DMM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\dmm\_Imports.razor"
using DMM.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\dmm\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
using Blazority;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mycampaigns")]
    public partial class MyCampaigns : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "div");
            __builder.AddAttribute(3, "style", "width:100%;height:60px;border-bottom: 2px solid darkred;");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "float:right;");
            __builder.OpenComponent<Blazority.Button>(6);
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                              () => NavigateToCreateCampaign()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Create Campaign");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "padding-top:12px;");
#nullable restore
#line 12 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
         foreach (var c in MyCampaignsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "CampaignDivSize hoverOutline");
            __builder.AddAttribute(15, "style", "text-align:center;");
            __builder.OpenElement(16, "div");
#nullable restore
#line 16 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                     if (c.Image == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<img class=\"imageSize\" src=\"/images/d20Red.webp\" alt=\"d20Red\" asp-append-version=\"true\">");
#nullable restore
#line 19 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                    }
                    else
                    {
                        string img = SharedMethods.ConvertImageToDisplay(c.Image);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "imageSize");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 23 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                                                     img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "alt", "d20Red");
            __builder.AddAttribute(22, "asp-append-version", "true");
            __builder.CloseElement();
#nullable restore
#line 24 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "margin-top:6px;");
            __builder.OpenElement(26, "b");
            __builder.AddAttribute(27, "style", "color:black;");
            __builder.AddContent(28, 
#nullable restore
#line 27 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
                                             c.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\repos\dmm\Pages\CampaignPages\MyCampaigns.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
