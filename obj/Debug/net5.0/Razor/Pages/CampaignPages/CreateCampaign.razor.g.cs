#pragma checksum "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c0a51d9554a1d4469a01883391cc22decee855"
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
#line 2 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
using Blazority;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mycampaigns/createcampaign")]
    public partial class CreateCampaign : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenComponent<Blazority.Button>(1);
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                  ()=>NavigateToMyCampaigns()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "My Campaigns");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Blazority.Form>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
              textAreaModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Blazority.Textarea>(9);
                __builder2.AddAttribute(10, "Label", "Campaign Title");
                __builder2.AddAttribute(11, "style", "resize:none;");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                                                  textAreaModel.InputName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textAreaModel.InputName = __value, textAreaModel.InputName))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => textAreaModel.InputName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    <br>\r\n    ");
                __builder2.OpenComponent<Blazority.Textarea>(16);
                __builder2.AddAttribute(17, "Label", "Campaign Description");
                __builder2.AddAttribute(18, "style", "resize:none;");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                                                        textAreaModel.InputDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textAreaModel.InputDescription = __value, textAreaModel.InputDescription))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => textAreaModel.InputDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    <br>\r\n    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(23);
                __builder2.AddAttribute(24, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 12 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                                         HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    <br>\r\n    ");
                __builder2.OpenComponent<Blazority.CheckboxContainer>(27);
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazority.Checkbox>(29);
                    __builder3.AddAttribute(30, "Label", "Public");
                    __builder3.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                                               textAreaModel.IsPublic

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => textAreaModel.IsPublic = __value, textAreaModel.IsPublic))));
                    __builder3.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => textAreaModel.IsPublic));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n<br>\r\n");
            __builder.OpenComponent<Blazority.Button>(35);
            __builder.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\repos\dmm\Pages\CampaignPages\CreateCampaign.razor"
                 ()=>SubmitCampaign()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, "Create Campaign");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
