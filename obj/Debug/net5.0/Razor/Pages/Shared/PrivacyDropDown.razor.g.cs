#pragma checksum "C:\Users\Erik\source\repos\DMM\Pages\Shared\PrivacyDropDown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbbdda93fe4ef3205275579869230040d8d497a"
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
#nullable restore
#line 12 "C:\Users\Erik\source\repos\DMM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Erik\source\repos\DMM\Pages\Shared\PrivacyDropDown.razor"
using Blazority;

#line default
#line hidden
#nullable disable
    public partial class PrivacyDropDown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<div class=\"dropdown\"><button class=\"dropbtn\">Privacy</button>\r\n                <div class=\"dropdown-content\"><a href=\"/PrivacyPolicy\">Privacy Policy</a>\r\n                    <a href=\"Identity/Account/Manage/PersonalData\">GDPR</a></div></div>");
            }
            ));
            __builder.AddAttribute(3, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "<div class=\"dropdown\"><button class=\"dropbtn\">Community</button>\r\n                <div class=\"dropdown-content\"><a href=\"/PrivacyPolicy\">Privacy Policy</a></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591