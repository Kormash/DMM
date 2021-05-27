using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DMM.Services;
using Blazority;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Components.Authorization;
using DMM.Models.Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;

namespace DMM.Pages.CampaignPages
{
    public partial class MyMonsters : ComponentBase
    {
        SharedMethods SharedMethods = new();
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        MonsterService MonsterService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }

        //Variables
        List<Campaign> MyMonsterList { get; set; }

        //UserVariables
        private string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await SharedMethods.CheckIfLoggedIn(AuthenticationStateProvider, NavigationManager);

            MyMonsterList = new();
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await UserManager.GetUserAsync(user);
                UserId = currentUser.Id;
            }
            else
            {
                NavigationManager.NavigateTo("/identity/account/login");
                UserId = "";
            }
        }


        

    }
}
