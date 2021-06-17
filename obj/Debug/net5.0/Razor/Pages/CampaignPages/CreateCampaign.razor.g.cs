#pragma checksum "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bb1975ca03b853a429beba07ff2c03872d6eb0b"
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
#line 2 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mycampaigns/createcampaign")]
    public partial class CreateCampaign : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "width:100%;min-height:60px;border-bottom: 2px solid darkred;");
            __builder.AddMarkupContent(2, "<div style=\"float:left;height:40px;width:90%;min-width:600px;\"><h1 style=\"font-weight:bold;margin:0 auto\">Create a Campaign</h1></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "width:10%;float:left;");
            __builder.OpenComponent<Blazority.Button>(5);
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                          () => NavigateToMyCampaigns()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "My Campaigns");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "style", "width:90%;margin:auto;");
            __builder.OpenComponent<Blazority.Form>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                  textAreaModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "style", "float:left;width:100%;height:50%;");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "style", "float:left;width:50%;");
                __builder2.AddMarkupContent(19, "<h4 style=\"font-weight:bold;\">Campaign Name</h4>\r\n                ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "placeholder", "Enter name...");
                __builder2.AddAttribute(23, "style", "resize:none; width:400px; height:40px;");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                       textAreaModel.InputName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => textAreaModel.InputName = __value, textAreaModel.InputName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "style", "float:left;width:50%;");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                               () => AddImageShow()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "class", "campaignIcon");
                __builder2.AddAttribute(32, "style", "border-radius:3px;");
#nullable restore
#line 27 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                     if (textAreaModel.ImgUpload != null)
                    {
                        string img = ConvertImage(textAreaModel.ImgUpload);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "img");
                __builder2.AddAttribute(34, "style", "height:100%;width:100%");
                __builder2.AddAttribute(35, "src", 
#nullable restore
#line 30 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                  img

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "alt", "Chosen Image");
                __builder2.AddAttribute(37, "asp-append-version", "true");
                __builder2.CloseElement();
#nullable restore
#line 31 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(38, "<img style=\"height:100%;width:100%\" src=\"/images/plus.png\" alt=\"Add Image\" asp-append-version=\"true\">");
#nullable restore
#line 35 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "style", "float:left;width:100%;margin-top:42px;");
                __builder2.AddMarkupContent(42, "<h4 style=\"font-weight:bold;\">Description</h4>\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "style", "border:2px solid darkgray;border-radius:6px;");
                __builder2.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(45);
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                                textAreaModel.InputDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textAreaModel.InputDescription = __value, textAreaModel.InputDescription))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => textAreaModel.InputDescription));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.RichTextEditor.RichTextEditorToolbarSettings>(50);
                    __builder3.AddAttribute(51, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.RichTextEditor.ToolbarItemModel>>(
#nullable restore
#line 43 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                                            Tools

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.RichTextEditor.ToolbarType>(
#nullable restore
#line 43 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                                                         ToolbarType.Expand

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n    <br>\r\n    ");
            __builder.OpenComponent<Blazority.Form>(54);
            __builder.AddAttribute(55, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 49 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                 textAreaModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazority.CheckboxContainer>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazority.Checkbox>(59);
                    __builder3.AddAttribute(60, "Label", "Public");
                    __builder3.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                   textAreaModel.IsPublic

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textAreaModel.IsPublic = __value, textAreaModel.IsPublic))));
                    __builder3.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => textAreaModel.IsPublic));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<Blazority.Button>(65);
                __builder2.AddAttribute(66, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                         ()=>SubmitCampaign()

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(68, "Create Campaign");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n");
            __builder.OpenComponent<Blazority.Modal>(70);
            __builder.AddAttribute(71, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
             AddImageModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "Closable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                      false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "ModalTitle", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(74, "Choose Image");
            }
            ));
            __builder.AddAttribute(75, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "style", "overflow:scroll");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "drag-drop-zone");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(80);
                __builder2.AddAttribute(81, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 62 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                     HandleSelection

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 64 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
             foreach (var icon in IconList)
            {
                string img = ConvertImage(icon.Image);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "style", "height:100px;width:100px;float:left;margin-top:6px;margin-left:6px;cursor:pointer");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                                                                         ()=>SelectImage(icon.Image)

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(85, "img");
                __builder2.AddAttribute(86, "style", "height:100%;width:100%");
                __builder2.AddAttribute(87, "src", 
#nullable restore
#line 68 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                              img

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(88, "alt", 
#nullable restore
#line 68 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                                                         icon.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(89, "asp-append-version", "true");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 70 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(90, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazority.Button>(91);
                __builder2.AddAttribute(92, "Variant", "Danger");
                __builder2.AddAttribute(93, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\repos\DMM\Pages\CampaignPages\CreateCampaign.razor"
                                          e => AddImageModal = false

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(95, "Abort");
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
