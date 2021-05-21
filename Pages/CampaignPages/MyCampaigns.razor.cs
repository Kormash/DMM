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

        //Variables
        List<Campaign> AllCampaigns { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await SharedMethods.CheckIfLoggedIn(AuthenticationStateProvider, NavigationManager);

            AllCampaigns = new();
            AllCampaigns = await CampaignService.GetAllCampaigns();
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
