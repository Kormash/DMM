#pragma checksum "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07eaaa0701e16e657908b65492d38107604ccdd5"
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
#line 2 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/campaign/{CampaignId:int}")]
    public partial class CampaignView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:100%;min-height:60px;border-bottom: 2px solid darkred;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "float:left;height:40px;width:90%;min-width:600px;");
            __builder.OpenElement(5, "h1");
            __builder.AddAttribute(6, "style", "font-weight:bold;margin:0 auto");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                            Campaign.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    <br>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "margin-top:12px;width:90%;margin:auto;border:2px solid darkgray;border-radius:6px;");
#nullable restore
#line 14 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
         if (CanEdit)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(11);
            __builder.AddAttribute(12, "SaveInterval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 16 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                                                      1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                             campaignModel.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => campaignModel.Description = __value, campaignModel.Description))));
            __builder.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => campaignModel.Description));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenComponent<Blazority.Button>(17);
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                              () => SaveCampaign()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "SAVE");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, 
#nullable restore
#line 21 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
             convertedMarkdown

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 21 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                              
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "padding-top:12px;");
#nullable restore
#line 26 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
         foreach (var a in AreaList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "AreaDivSize hoverOutline");
            __builder.AddAttribute(27, "style", "text-align:center;");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                       () => NavigateToArea(a.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(29, "div");
#nullable restore
#line 30 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                     if (a.Image == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<img class=\"iconImageSize\" src=\"/images/d20Red.webp\" alt=\"d20Red\" asp-append-version=\"true\">");
#nullable restore
#line 33 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                    }
                    else
                    {
                        string img = SharedMethods.ConvertImageToDisplay(a.Image);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "img");
            __builder.AddAttribute(32, "class", "iconImageSize");
            __builder.AddAttribute(33, "src", 
#nullable restore
#line 37 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                         img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "alt", "d20Red");
            __builder.AddAttribute(35, "asp-append-version", "true");
            __builder.CloseElement();
#nullable restore
#line 38 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-top:6px;");
            __builder.OpenElement(39, "b");
            __builder.AddAttribute(40, "style", "color:black;");
            __builder.AddContent(41, 
#nullable restore
#line 41 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                             a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
         if (CanEdit)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "AreaDivSize");
            __builder.AddAttribute(44, "hidden", 
#nullable restore
#line 47 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                              hideAddArea

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Blazority.Form>(45);
            __builder.AddAttribute(46, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                              areaModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                   () => AddImageShow()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "class", "campaignIcon");
#nullable restore
#line 50 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                         if (areaModel.Image != null)
                        {
                            string img = ConvertImage(areaModel.Image);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(51, "img");
                __builder2.AddAttribute(52, "style", "height:100%;width:100%");
                __builder2.AddAttribute(53, "src", 
#nullable restore
#line 53 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                      img

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(54, "alt", "Chosen Image");
                __builder2.AddAttribute(55, "asp-append-version", "true");
                __builder2.CloseElement();
#nullable restore
#line 54 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(56, "<img style=\"height:100%;width:100%\" src=\"/images/plus.png\" alt=\"Add Image\" asp-append-version=\"true\">");
#nullable restore
#line 58 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "style", "margin-left: auto; margin-right: auto; display:block;width:45%;align-content:center");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "type", "text");
                __builder2.AddAttribute(62, "style", "width:100% ");
                __builder2.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                   areaModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => areaModel.Name = __value, areaModel.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n                    ");
                __builder2.OpenComponent<Blazority.Button>(66);
                __builder2.AddAttribute(67, "Variant", "Primary");
                __builder2.AddAttribute(68, "style", "margin-left: auto; margin-right: auto;float:right");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                                                  () => SaveArea()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, "Create");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.OpenComponent<Blazority.Button>(73);
                __builder2.AddAttribute(74, "Variant", "Danger");
                __builder2.AddAttribute(75, "style", "margin-left: auto; margin-right: auto;float:right");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                                                 () => CancelAddNewArea()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(78, "Cancel");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "AreaDivSize hoverOutline");
            __builder.AddAttribute(81, "style", "text-align:center;");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                       () => AddNewArea()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "hidden", 
#nullable restore
#line 72 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                                                    hideNewAddArea

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(84, "<div><img class=\"imageSize\" src=\"/images/plus.png\" alt=\"plus\" asp-append-version=\"true\"></div>\r\n                ");
            __builder.AddMarkupContent(85, "<div style=\"margin-top:6px;\"><b style=\"color:black;\">Add new Area</b></div>");
            __builder.CloseElement();
#nullable restore
#line 80 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n");
            __builder.OpenComponent<Blazority.Modal>(87);
            __builder.AddAttribute(88, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
             AddImageModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "Closable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "ModalTitle", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(91, "Choose Image");
            }
            ));
            __builder.AddAttribute(92, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "style", "overflow:scroll");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "drag-drop-zone");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(97);
                __builder2.AddAttribute(98, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 94 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                     HandleSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 96 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
             foreach (var icon in IconList)
            {
                string img = ConvertImage(icon.Image);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "style", "height:100px;width:100px;float:left;margin-top:6px;margin-left:6px;cursor:pointer");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                                                                         ()=>SelectImage(icon.Image)

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(102, "img");
                __builder2.AddAttribute(103, "style", "height:100%;width:100%");
                __builder2.AddAttribute(104, "src", 
#nullable restore
#line 100 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                              img

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(105, "alt", 
#nullable restore
#line 100 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                                                         icon.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(106, "asp-append-version", "true");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 102 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(107, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazority.Button>(108);
                __builder2.AddAttribute(109, "Variant", "Danger");
                __builder2.AddAttribute(110, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "D:\repos\DMM\Pages\CampaignPages\CampaignView.razor"
                                          e => AddImageModal = false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(112, "Abort");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
