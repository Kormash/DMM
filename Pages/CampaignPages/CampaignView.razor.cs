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
using BlazorInputFile;
using System.IO;

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
        AreaService AreaService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }

        //Variables
        private Campaign Campaign = new Campaign();
        private Area Area = new Area();
        [Parameter]
        public int CampaignId { get; set; }
        public bool EditCampaignDisabled = true;
        private CampaignModel campaignModel = new();
        private AreaModel areaModel = new();
        public List<Area> AreaList = new();
        public bool hideAddArea = true;

        //UserVariables
        private string UserId { get; set; }
        private bool CanEdit { get; set; }

        private MarkupString convertedMarkdown { get; set; }

        protected override void OnParametersSet()
        {
            // Required Markdig https://www.nuget.org/packages/Markdig/
            var html = Markdig.Markdown.ToHtml(campaignModel.Description ?? "");
            convertedMarkdown = (MarkupString)html; // or new MarkupString(html)
        }

        public class CampaignModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Image { get; set; }
        }

        public class AreaModel
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

            campaignModel.Name = Campaign.Name;
            campaignModel.Description = Campaign.Description;
            campaignModel.Image = Campaign.Image;

            AreaList = await AreaService.GetAreasByCampaignID(CampaignId);
        } 

        public async Task SaveCampaign()
        {
            Campaign c = Campaign;

            c.Name = campaignModel.Name;
            c.Description = campaignModel.Description;
            c.Image = campaignModel.Image;

            await CampaignService.Update(c);
        }

        public async Task AddNewArea()
        {
            hideAddArea = false;
        }

        async Task HandleSelection(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if(file.Name.EndsWith(".jpg") || file.Name.EndsWith(".png"))
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                areaModel.Image = ms.ToArray();
            }
        }

        public async Task SaveArea()
        {
            Area a = new();

            a.CampaignID = CampaignId;
            a.Name = areaModel.Name;
            if(areaModel.Image != null)
            {
                a.Image = areaModel.Image;
            }
            await AreaService.Insert(a);
        }

        public void NavigateToArea(int areaID)
        {

        }


    }
}
