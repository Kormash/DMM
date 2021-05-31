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
        public string monsterName = "";

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
                    string url = Regex.Replace(monsterString[5], "\"", "");
                    monsterItem.url = Regex.Replace(url, "/api", "");
                    monsterItem.apiResponse = "";

                    MonsterList.Add(monsterItem);

                }

            }

        }

        public async Task MonsterDetails(MonsterItem monster)
        {
            if (monster.apiResponse == "" || monster.apiResponse == null)
            {
                try
                {
                    string address = "https://www.dnd5eapi.co/api/" + monster.url;
                    HttpResponseMessage response = await Http.GetAsync(address);
                    response.EnsureSuccessStatusCode();
                    monster.apiResponse = await response.Content.ReadAsStringAsync();



                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }

            monster.Monster.Name = GetMonsterName(monster.apiResponse);
            monster.Monster.Size = GetMonsterSize(monster.apiResponse);
            monster.Monster.Type = GetMonsterType(monster.apiResponse);
            monster.Monster.SubType = GetMonsterSubtype(monster.apiResponse);
            monster.Monster.Alignment = GetMonsterAlignment(monster.apiResponse);
            monster.Monster.ArmorClass = GetMonsterArmorClass(monster.apiResponse);
            monster.Monster.HitPoints = GetMonsterHitPoints(monster.apiResponse);
            monster.Monster.Speed = GetMonsterSpeed(monster.apiResponse);
            monster.Monster.Strength = GetMonsterStrength(monster.apiResponse);
            monster.Monster.Dexterity = GetMonsterDexterity(monster.apiResponse);
            monster.Monster.Constitution = GetMonsterConstitution(monster.apiResponse);
            monster.Monster.Intelligence = GetMonsterIntelligence(monster.apiResponse);
            monster.Monster.Wisdom = GetMonsterWisdom(monster.apiResponse);
            monster.Monster.Charisma = GetMonsterCharisma(monster.apiResponse);
            monster.Monster.HitDice = GetMonsterHitDice(monster.apiResponse, monster.Monster.Constitution);


            monster.hidden = !monster.hidden;
        }
        public int GetModifier(int stat)
        {
            double statDouble = stat;
            return (int)Math.Floor((statDouble - 10) / 2);
        }
        public string GetMonsterName(string apiResponse)
        {
            string name = Regex.Match(apiResponse, "name\":\".+?\"").Value;

            name = Regex.Replace(name, "\"", "");
            name = Regex.Replace(name, "name:", "");
            return name;
        }
        public string GetMonsterSize(string apiResponse)
        {
            string size = Regex.Match(apiResponse, "size\":\".+?\"").Value;

            size = Regex.Replace(size, "\"", "");
            size = Regex.Replace(size, "size:", "");
            return size;
        }
        public string GetMonsterType(string apiResponse)
        {
            string type = Regex.Match(apiResponse, "type\":\".+?\"").Value;

            type = Regex.Replace(type, "\"", "");
            type = Regex.Replace(type, "type:", "");
            return type;
        }
        public string GetMonsterSubtype(string apiResponse)
        {
            string subtype = Regex.Match(apiResponse, "subtype\":\".+?,").Value;

            subtype = Regex.Replace(subtype, ",", "");
            subtype = Regex.Replace(subtype, "subtype\":", "");
            subtype = Regex.Replace(subtype, "\"", "");
            return subtype;
        }
        public string GetMonsterAlignment(string apiResponse)
        {
            string alignment = Regex.Match(apiResponse, "alignment\":\".+?\"").Value;

            alignment = Regex.Replace(alignment, "\"", "");
            alignment = Regex.Replace(alignment, "alignment:", "");
            return alignment;
        }
        public int GetMonsterArmorClass(string apiResponse)
        {
            int result = 0;
            string ac = Regex.Match(apiResponse, "armor_class\":.+?,").Value;

            ac = Regex.Replace(ac, ",", "");
            ac = Regex.Replace(ac, "armor_class\":", "");
            ac = Regex.Replace(ac, "\"", "");
            try
            {
                result = int.Parse(ac);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterHitPoints(string apiResponse)
        {
            int result = 0;
            string hp = Regex.Match(apiResponse, "hit_points\":.+?,").Value;

            hp = Regex.Replace(hp, ",", "");
            hp = Regex.Replace(hp, "hit_points\":", "");
            hp = Regex.Replace(hp, "\"", "");
            try
            {
                result = int.Parse(hp);
            }
            catch
            {
            }
            return result;
        }
        public string GetMonsterHitDice(string apiResponse, int ConstitutionStat)
        {
            string hd = Regex.Match(apiResponse, "hit_dice\":\".+?\"").Value;
            int diceCount = -10000;

            hd = Regex.Replace(hd, "\"", "");
            hd = Regex.Replace(hd, "hit_dice:", "");

            int ConMod = GetModifier(ConstitutionStat);
            
            try
            {
                diceCount = int.Parse(Regex.Replace(hd, "d.+", ""));
            }
            catch
            {

            }

            int result = diceCount * ConMod;

            if (result >= 0)
            {
                hd = hd + "+";
            }

            return hd + result;
        }
        public string GetMonsterSpeed(string apiResponse)
        {
            string speed = Regex.Match(apiResponse, "speed\":\\{.+?\\}").Value;

            speed = Regex.Replace(speed, "\\}", "");
            speed = Regex.Replace(speed, "speed\":\\{", "");
            speed = Regex.Replace(speed, "\"", "");
            speed = Regex.Replace(speed, "walk:", "");

            return speed;
        }
        public int GetMonsterStrength(string apiResponse)
        {
            int result = 0;
            string str = Regex.Match(apiResponse, "strength\":.+?,").Value;

            str = Regex.Replace(str, ",", "");
            str = Regex.Replace(str, "strength\":", "");
            str = Regex.Replace(str, "\"", "");
            try
            {
                result = int.Parse(str);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterDexterity(string apiResponse)
        {
            int result = 0;
            string dex = Regex.Match(apiResponse, "dexterity\":.+?,").Value;

            dex = Regex.Replace(dex, ",", "");
            dex = Regex.Replace(dex, "dexterity\":", "");
            dex = Regex.Replace(dex, "\"", "");
            try
            {
                result = int.Parse(dex);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterConstitution(string apiResponse)
        {
            int result = 0;
            string con = Regex.Match(apiResponse, "constitution\":.+?,").Value;

            con = Regex.Replace(con, ",", "");
            con = Regex.Replace(con, "constitution\":", "");
            con = Regex.Replace(con, "\"", "");
            try
            {
                result = int.Parse(con);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterIntelligence(string apiResponse)
        {
            int result = 0;
            string intelligence = Regex.Match(apiResponse, "intelligence\":.+?,").Value;

            intelligence = Regex.Replace(intelligence, ",", "");
            intelligence = Regex.Replace(intelligence, "intelligence\":", "");
            intelligence = Regex.Replace(intelligence, "\"", "");
            try
            {
                result = int.Parse(intelligence);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterWisdom(string apiResponse)
        {
            int result = 0;
            string wis = Regex.Match(apiResponse, "wisdom\":.+?,").Value;

            wis = Regex.Replace(wis, ",", "");
            wis = Regex.Replace(wis, "wisdom\":", "");
            wis = Regex.Replace(wis, "\"", "");
            try
            {
                result = int.Parse(wis);
            }
            catch
            {
            }
            return result;
        }
        public int GetMonsterCharisma(string apiResponse)
        {
            int result = 0;
            string cha = Regex.Match(apiResponse, "charisma\":.+?,").Value;

            cha = Regex.Replace(cha, ",", "");
            cha = Regex.Replace(cha, "charisma\":", "");
            cha = Regex.Replace(cha, "\"", "");
            try
            {
                result = int.Parse(cha);
            }
            catch
            {
            }
            return result;
        }
        public string GetMonsterProficiencies(string apiResponse)
        {
            string proficiency = Regex.Match(apiResponse, "proficiencies\":\\[.+?\\]").Value;

            proficiency = Regex.Replace(proficiency, "\\]", "");
            proficiency = Regex.Replace(proficiency, "proficiencies\":\\[", "");

            String[] proficiencyList = proficiency.Split("},", StringSplitOptions.RemoveEmptyEntries);

            foreach (var p in proficiencyList)
            {
                //Manipulate
            }

            return proficiencyList[0];
        }
    }

    public class MonsterItem
    {
        public MonsterTemplate Monster = new();
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string apiResponse { get; set; }
        public bool hidden = true;
    }
}
