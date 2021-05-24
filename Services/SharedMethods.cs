using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DMM.Services
{
    public class SharedMethods
    {
        
        public async Task CheckIfLoggedIn(AuthenticationStateProvider AuthenticationStateProvider, NavigationManager NavigationManager)
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (!user.Identity.IsAuthenticated)
            {
                NavigationManager.NavigateTo("/identity/account/login");
            }
        }
        public string ConvertImageToDisplay(byte[] Image)
        {
            if (Image != null)
            {
                var base64 = Convert.ToBase64String(Image);
                var fs = string.Format("data:image/jpg;base64,{0}", base64);
                return fs;
            }

            return "";
        }
    }
}
