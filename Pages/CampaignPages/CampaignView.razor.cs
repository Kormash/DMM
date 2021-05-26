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
    public partial class CampaignView : ComponentBase
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
        private Campaign Campaign = new Campaign();
        [Parameter]
        public int CampaignId { get; set; }
        public bool EditCampaignDisabled = true;
        private CampaignModel Model = new();

        //UserVariables
        private string UserId { get; set; }
        private bool CanEdit { get; set; }

        private MarkupString convertedMarkdown { get; set; }

        protected override void OnParametersSet()
        {
            // Required Markdig https://www.nuget.org/packages/Markdig/
            var html = Markdig.Markdown.ToHtml(Model.Description ?? "");
            convertedMarkdown = (MarkupString)html; // or new MarkupString(html)
        }

        public class CampaignModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Image { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            Campaign = (await CampaignService.GetCampaignByID(CampaignId));

            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await UserManager.GetUserAsync(user);
                UserId = currentUser.Id;
                if(UserId == Campaign.UserId)
                {
                    CanEdit = true;
                }
            }
            else
            {
                CanEdit = false;
            }

            Model.Name = Campaign.Name;
            Model.Description = Campaign.Description;
            Model.Image = Campaign.Image;
        } 

        public async Task SaveCampaign()
        {
            Campaign c = Campaign;

            c.Name = Model.Name;
            c.Description = Model.Description;
            c.Image = Model.Image;

            await CampaignService.Update(c);
        }
    }
}
