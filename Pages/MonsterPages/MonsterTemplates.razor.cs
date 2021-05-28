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

namespace DMM.Pages.MonsterPages
{
    public partial class MonsterTemplates : ComponentBase
    {
        SharedMethods SharedMethods = new();
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        MonsterTemplateService MonsterTemplateService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }
        [Inject]
        HttpClient Http { get; set; }

        //Variables
        public string Output = "Hello World!";

        public List<MonsterItem> MonsterList = new();
        //UserVariables
        private string UserId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await UserManager.GetUserAsync(user);
                UserId = currentUser.Id;
            }
            else
            {
                UserId = "";
            }
            
            await MonsterAPICall();
            FormatMonsterList();
            

        }

        public async Task MonsterAPICall()
        {
            try
            {
                HttpResponseMessage response = await Http.GetAsync("https://www.dnd5eapi.co/api/monsters");
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

        public void FormatMonsterList()
        {
            Output = Regex.Match(Output, @"\[[^\]]*").Value;
            Output = Regex.Replace(Output, "\\[", "");
            
            char[] sperators = new char[] { '{', '}' };
            String[] MonsterStrings = Output.Split(sperators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string monster in MonsterStrings)
            {
                if (!monster.Equals(","))
                {
                    char[] sperator = new char[] { ',', ':' };
                    String[] monsterString = monster.Split(sperator, StringSplitOptions.RemoveEmptyEntries);

                    MonsterItem monsterItem = new();

                    monsterItem.index = Regex.Replace(monsterString[1], "\"", "");
                    monsterItem.name = Regex.Replace(monsterString[3], "\"", "");
                    monsterItem.url = Regex.Replace(monsterString[5], "\"", "");

                    MonsterList.Add(monsterItem);
                    
                }

            }

        }

        public void NavigateToMonster(string url)
        {

        }

    }

    public class MonsterItem
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
