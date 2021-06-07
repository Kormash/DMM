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
using System.Text.RegularExpressions;

namespace DMM.Pages.AdminPages
{
    public partial class Administration : ComponentBase
    {
        [Inject]
        IconService IconService { get; set; }
        //Variables
        IFileListEntry[] selectedFiles;

        protected override async Task OnInitializedAsync()
        {
            
        }

        async Task HandleSelection(IFileListEntry[] files)
        {
            foreach(var file in files)
            {
                Icon i = new();

                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                i.Image = ms.ToArray();

                i.Name = Regex.Replace(file.Name, "\\..+", "");

                await IconService.Insert(i);
            }
        }

        async Task LoadFile(IFileListEntry file)
        {
            // So the UI updates to show progress
            file.OnDataRead += (sender, eventArgs) => InvokeAsync(StateHasChanged);

            // Just load into .NET memory to show it can be done
            // Alternatively it could be saved to disk, or parsed in memory, or similar
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
        }


    }
}
