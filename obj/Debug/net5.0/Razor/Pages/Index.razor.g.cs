#pragma checksum "C:\Users\Erik\source\repos\DMM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7098de3a8c38f36b9987198e55b9b7652fa3a0ed"
// <auto-generated/>
#pragma warning disable 1591
namespace DMM.Pages
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
#nullable restore
#line 12 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erik\source\repos\DMM\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Erik\source\repos\DMM\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "body");
            __builder.AddMarkupContent(1, "<div style=\"width:100%;min-height:60px;border-bottom: 2px solid darkred;\"><div style=\"float:left;height:40px;width:90%;min-width:600px;\"><h1 style=\"font-weight:bold;margin:0 auto\">Home</h1></div></div>\r\n\r\n    <br>\r\n\r\n    ");
            __builder.AddMarkupContent(2, @"<div class=""frontpage""><div class=""fp-cell fp-cell--1""><div class=""fp-item"">1</div></div>
        <div class=""fp-cell fp-cell--2""><div class=""fp-item"">2</div></div>
        <div class=""fp-cell fp-cell--3 fp-cell--border-top""><div class=""fp-item"">3</div></div>
        <div class=""fp-cell fp-cell--4 fp-cell--border-top""><div class=""fp-item"">4</div></div></div>

    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 33 "C:\Users\Erik\source\repos\DMM\Pages\Index.razor"
         userAuthenticated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Erik\source\repos\DMM\Pages\Index.razor"
      
    string userAuthenticated;
    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            var currentUser = await UserManager.GetUserAsync(user);
            //userAuthenticated = $"{ currentUser.Id} ";
        }
        else
        {
            userAuthenticated = "The user is NOT authenticated.";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
