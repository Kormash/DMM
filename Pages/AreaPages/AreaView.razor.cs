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
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DMM.Pages.AreaPages
{
    public partial class AreaView : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }
        //Variables
        string Output = "Temp Text";
        [Parameter]
        public int AreaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await DiceAPICall();
        }

        public async Task DiceAPICall()
        {
            try
            {
                HttpResponseMessage response = await Http.GetAsync("https://localhost:44327/Dice/2/5");
                response.EnsureSuccessStatusCode();
                Output = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
