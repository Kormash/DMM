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
    public partial class CommunityCampaigns : ComponentBase
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
        List<Campaign> AllCampaignsList { get; set; }

        //UserVariables
        private string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {

            AllCampaignsList = new();
            AllCampaignsList = await CampaignService.GetAllPublicCampaigns();
        }

        public void NavigateToCreateCampaign()
        {
            NavigationManager.NavigateTo("/mycampaigns/createcampaign");
        }

        public void NavigateToCampaignView(int CampaignId)
        {
            NavigationManager.NavigateTo($"/campaign/{CampaignId}");
        }
    }
}
