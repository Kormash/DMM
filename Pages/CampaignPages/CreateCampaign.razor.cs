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
using Microsoft.AspNetCore.Identity;
using Syncfusion.Blazor.RichTextEditor;

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
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }
        [Inject]
        IconService IconService { get; set; }

        //Model for TextAreas
        private TextAreaModel textAreaModel = new TextAreaModel();


        //Variables for File handling
        IFileListEntry file;
        bool AddImageModal = false;
        public List<Icon> IconList = new();

        //UserVariables
        private string UserId { get; set; }


        protected override async Task OnInitializedAsync()
        {
            await SharedMethods.CheckIfLoggedIn(AuthenticationStateProvider, NavigationManager);
            IconList = await IconService.GetAllIcons();

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

        public class TextAreaModel
        {
            public string InputName { get; set; }
            public string InputDescription { get; set; }
            public byte[] ImgUpload { get; set; }
            public bool IsPublic = false;
        }
        public async Task SubmitCampaign()
        {
            Campaign c = new();
            c.UserId = UserId;
            c.Name = textAreaModel.InputName;
            c.Description = textAreaModel.InputDescription;
            c.IsPublic = textAreaModel.IsPublic;
            if (textAreaModel.ImgUpload != null)
            {
                c.Image = textAreaModel.ImgUpload;
            }

            await CampaignService.InsertMyCampaign(c);
            NavigationManager.NavigateTo("/mycampaigns");
        }
        public void AddImageShow()
        {
            AddImageModal = true;
        }
        public string ConvertImage(byte[] Image)
        {
            return SharedMethods.ConvertImageToDisplay(Image);
        }
        public void NavigateToMyCampaigns()
        {
            NavigationManager.NavigateTo("/mycampaigns");
        }

        async Task HandleSelection(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file.Name.EndsWith(".jpg") || file.Name.EndsWith(".png"))
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                textAreaModel.ImgUpload = ms.ToArray();
                AddImageModal = false;
            }
        }
        public void SelectImage(byte[] Image)
        {
            textAreaModel.ImgUpload = Image;
            AddImageModal = false;
        }
        private List<ToolbarItemModel> Tools = new List<ToolbarItemModel>()
        {
            new ToolbarItemModel() { Command = ToolbarCommand.Bold },
            new ToolbarItemModel() { Command = ToolbarCommand.Italic },
            new ToolbarItemModel() { Command = ToolbarCommand.Underline },
            new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
            new ToolbarItemModel() { Command = ToolbarCommand.Separator },
            new ToolbarItemModel() { Command = ToolbarCommand.FontName },
            new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
            new ToolbarItemModel() { Command = ToolbarCommand.Separator },
            new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
            new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
            new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
            new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
            new ToolbarItemModel() { Command = ToolbarCommand.Undo },
            new ToolbarItemModel() { Command = ToolbarCommand.Redo }
        };
    }
}