using DMM.Models.Entities;
using DMM.Services.Shared;
using DMM.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazority;
using System.IO;
using Microsoft.AspNetCore.Components.Forms;
using BlazorInputFile;

namespace DMM.Pages.CampaignPages
{
    public partial class CreateCampaign : ComponentBase
    {
        SharedMethods SharedMethods = new();
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        CampaignService CampaignService { get; set; }

        //Model for TextAreas
        private TextAreaModel textAreaModel = new TextAreaModel();

        //Variables for File handling
        IFileListEntry file;

        protected override async Task OnInitializedAsync()
        {
            await SharedMethods.CheckIfLoggedIn(AuthenticationStateProvider, NavigationManager);
        }

        public class TextAreaModel
        {
            public string InputName { get; set; }
            public string InputDescription { get; set; }
            public byte[] ImgUpload { get; set; }
        }
        public async Task SubmitCampaign()
        {
            Campaign c = new();
            c.Name = textAreaModel.InputName;
            c.Description = textAreaModel.InputDescription;
            if (textAreaModel.ImgUpload != null)
            {
                c.Image = textAreaModel.ImgUpload;
            }

            await CampaignService.InsertMyCampaign(c);
            NavigationManager.NavigateTo("/mycampaigns");
        }
        public void NavigateToMyCampaigns()
        {
            NavigationManager.NavigateTo("/mycampaigns");
        }

        async Task HandleFileSelected(IFileListEntry[] files)
        {
            file = files.FirstOrDefault();
            if (files != null)
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                textAreaModel.ImgUpload = ms.ToArray();
            }
        }

    }
}