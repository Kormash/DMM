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
    public partial class MyCampaigns : ComponentBase
    {
        SharedMethods SharedMethods = new();
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        CampaignService CampaignService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }

        //Variables
        List<Campaign> MyCampaignsList { get; set; }

        //UserVariables
        private string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await SharedMethods.CheckIfLoggedIn(AuthenticationStateProvider, NavigationManager);

            MyCampaignsList = new();
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await UserManager.GetUserAsync(user);
                UserId = currentUser.Id;
                MyCampaignsList = await CampaignService.GetCampaignsByUserId(UserId);
            }
            else
            {
                NavigationManager.NavigateTo("/identity/account/login");
                UserId = "";
            }
        }

        public void NavigateToCreateCampaign()
        {
            NavigationManager.NavigateTo("/mycampaigns/createcampaign");
        }

        void HandleFileSelected()
        {
            // Do something with the files, e.g., read them
        }

        private void LoadFiles(InputFileChangeEventArgs e)
        {

        }
        

    }
}
