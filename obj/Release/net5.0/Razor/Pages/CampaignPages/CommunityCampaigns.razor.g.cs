#pragma checksum "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e9dc5f0b3981bf3ca437638da128cf6af621d5"
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
#line 2 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
using Blazority;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/campaigns")]
    public partial class CommunityCampaigns : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "<div style=\"width:100%;min-height:60px;border-bottom: 2px solid darkred;\"><div style=\"float:left;height:40px;width:90%;min-width:600px;\"><h1 style=\"font-weight:bold;margin:0 auto\">Community Campaigns</h1></div></div>\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "padding-top:12px;");
#nullable restore
#line 12 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
         foreach (var c in AllCampaignsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "CampaignDivSize hoverOutline");
            __builder.AddAttribute(6, "style", "text-align:center;");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                                                                                            () => NavigateToCampaignView(c.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "div");
#nullable restore
#line 16 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                     if (c.Image == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<img class=\"imageSize\" src=\"/images/d20Red.webp\" alt=\"d20Red\" asp-append-version=\"true\">");
#nullable restore
#line 19 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                    }
                    else
                    {
                        string img = SharedMethods.ConvertImageToDisplay(c.Image);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "imageSize");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 23 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                                                     img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", "d20Red");
            __builder.AddAttribute(14, "asp-append-version", "true");
            __builder.CloseElement();
#nullable restore
#line 24 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "margin-top:6px;");
            __builder.OpenElement(18, "b");
            __builder.AddAttribute(19, "style", "color:black;");
            __builder.AddContent(20, 
#nullable restore
#line 27 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
                                             c.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\repos\DMM\Pages\CampaignPages\CommunityCampaigns.razor"
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