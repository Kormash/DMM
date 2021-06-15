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
using DMM.Pages.AreaPages;

namespace DMM.Pages.Shared
{
    public partial class MonsterDiv : ComponentBase
    {
        SharedMethods SharedMethods = new();
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject]
        MonsterTemplateService MonsterTemplateService { get; set; }
        [Inject]
        MonsterService monsterService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }
        [Inject]
        HttpClient Http { get; set; }

        [Parameter]
        public int LocationId { get; set; }

        public string TempOutput = "";

        //Variables
        public string Output = "Hello World!";
        public string monsterName = "";
        List<ActionModel> ActionList = new();
        public List<MonsterTemplate> AddMonsterList = new();

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
                    
                    String[] monsterString = monster.Split("\",", StringSplitOptions.RemoveEmptyEntries);

                    MonsterItem monsterItem = new();
                    string index = Regex.Replace(monsterString[0], "\"index\":", "");
                    string name = Regex.Replace(monsterString[1], "\"name\":", "");
                    string url = Regex.Replace(monsterString[2], "\"url\":", "");
                    index = Regex.Replace(index, "\"", "");
                    name = Regex.Replace(name, "\"", "");
                    url = Regex.Replace(url, "/api", "");
                    url = Regex.Replace(url, "\"", "");

                    monsterItem.index = index;
                    monsterItem.name = name;
                    monsterItem.url = url;

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
                monster.Monster.SavingThrows = GetMonsterSavingThrows(monster.apiResponse);
                monster.Monster.Skills = GetMonsterSkills(monster.apiResponse);
                monster.Monster.DamageVulnerabilities = GetMonsterVulnerabilities(monster.apiResponse);
                monster.Monster.DamageResistances = GetMonsterResistances(monster.apiResponse);
                monster.Monster.DamageImmunities = GetMonsterImmunities(monster.apiResponse);
                monster.Monster.ConditionImmunities = GetMonsterConditionImmunities(monster.apiResponse);
                monster.Monster.Senses = GetMonsterSenses(monster.apiResponse);
                monster.Monster.Languages = GetMonsterLanguages(monster.apiResponse);
                monster.Monster.Challange = GetMonsterChallenge(monster.apiResponse);
                monster.AbilityList = GetMonsterAbilities(monster.apiResponse);
                monster.ActionList = GetMonsterAction(monster.apiResponse);
                monster.LegendaryActionList = GetMonsterLegendaryAction(monster.apiResponse);

            }

            

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

            if (result > 0)
            {
                hd = hd + "+";
            }else if (result == 0)
            {
                return hd;
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
        public string GetMonsterSavingThrows(string apiResponse)
        {
            string proficiency = Regex.Match(apiResponse, "proficiencies\":\\[.+?\\]").Value;

            proficiency = Regex.Replace(proficiency, "\\]", "");
            proficiency = Regex.Replace(proficiency, "proficiencies\":\\[", "");

            String[] proficiencyList = proficiency.Split("},", StringSplitOptions.RemoveEmptyEntries);

            string SavingThrowresults = "";

            foreach (var p in proficiencyList)
            {
                if(p.Contains("Saving Throw"))
                {
                    string st = Regex.Match(p, "Saving Throw:.+?\"").Value;

                    st = Regex.Replace(st, "\"", "");
                    st = Regex.Replace(st, "Saving Throw:", "");

                    string value = Regex.Match(p, "value\":.+?,").Value;

                    value = Regex.Replace(value, ",", "");
                    value = Regex.Replace(value, "value\":", "");
                    value = Regex.Replace(value, "\"", "");

                    if (SavingThrowresults != "")
                    {
                        SavingThrowresults = SavingThrowresults + ", "+ st + " +" + value;
                    }
                    else
                    {
                        SavingThrowresults = SavingThrowresults + st + " +" + value;
                    }

                }
            }

            return SavingThrowresults; 
        }
        public string GetMonsterSkills(string apiResponse)
        {
            string proficiency = Regex.Match(apiResponse, "proficiencies\":\\[.+?\\]").Value;

            proficiency = Regex.Replace(proficiency, "\\]", "");
            proficiency = Regex.Replace(proficiency, "proficiencies\":\\[", "");

            String[] proficiencyList = proficiency.Split("},", StringSplitOptions.RemoveEmptyEntries);

            string SkillResults = "";

            foreach (var p in proficiencyList)
            {
                if (p.Contains("Skill"))
                {
                    string st = Regex.Match(p, "Skill:.+?\"").Value;

                    st = Regex.Replace(st, "\"", "");
                    st = Regex.Replace(st, "Skill:", "");

                    string value = Regex.Match(p, "value\":.+?,").Value;

                    value = Regex.Replace(value, ",", "");
                    value = Regex.Replace(value, "value\":", "");
                    value = Regex.Replace(value, "\"", "");

                    if (SkillResults != "")
                    {
                        SkillResults = SkillResults + ", " + st + " +" + value;
                    }
                    else
                    {
                        SkillResults = SkillResults + st + " +" + value;
                    }

                }
            }

            return SkillResults;
        }
        public string GetMonsterVulnerabilities(string apiResponse)
        {
            string dv = Regex.Match(apiResponse, "damage_vulnerabilities\":\\[.*?\\]").Value;

            dv = Regex.Replace(dv, "\\]", "");
            dv = Regex.Replace(dv, "damage_vulnerabilities\":\\[", "");
            dv = Regex.Replace(dv, "\"","");
            dv = Regex.Replace(dv, ",", ", ");
            dv = Regex.Replace(dv, ",  ", ", ");

            return dv;
        }
        public string GetMonsterResistances(string apiResponse)
        {
            string dr = Regex.Match(apiResponse, "damage_resistances\":\\[.*?\\]").Value;

            dr = Regex.Replace(dr, "\\]", "");
            dr = Regex.Replace(dr, "damage_resistances\":\\[", "");
            dr = Regex.Replace(dr, "\"", "");
            dr = Regex.Replace(dr, ",", ", ");

            return dr;
        }
        public string GetMonsterImmunities(string apiResponse)
        {
            string di = Regex.Match(apiResponse, "damage_immunities\":\\[.*?\\]").Value;

            di = Regex.Replace(di, "\\]", "");
            di = Regex.Replace(di, "damage_immunities\":\\[", "");
            di = Regex.Replace(di, "\"", "");
            di = Regex.Replace(di, ",", ", ");
            di = Regex.Replace(di, ",  ", ", ");

            return di;
        }
        public string GetMonsterConditionImmunities(string apiResponse)
        {
            string ci = Regex.Match(apiResponse, "condition_immunities\":\\[.*?\\]").Value;

            ci = Regex.Replace(ci, "\\]", "");
            ci = Regex.Replace(ci, "condition_immunities\":\\[", "");
            ci = Regex.Replace(ci, "\"", "");

            String[] ConditionList = ci.Split("},", StringSplitOptions.RemoveEmptyEntries);

            string ConditionResult = "";

            foreach (var p in ConditionList)
            {

                string st = Regex.Match(p, "name:.+?,").Value;

                st = Regex.Replace(st, ",", "");
                st = Regex.Replace(st, "name:", "");

                if (ConditionResult != "")
                {
                    ConditionResult = ConditionResult + ", " + st;
                }
                else
                {
                    ConditionResult = ConditionResult + st;
                }



            }
            return ConditionResult;
        }
        public string GetMonsterSenses(string apiResponse)
        {

            string sense = Regex.Match(apiResponse, "senses\":\\{.+?\\}").Value; ;

            sense = Regex.Replace(sense, "\\}", "");
            sense = Regex.Replace(sense, "senses\":\\{", "");
            sense = Regex.Replace(sense, "\"", "");
            sense = Regex.Replace(sense, ":", " ");
            sense = Regex.Replace(sense, "_", " ");
            sense = Regex.Replace(sense, ",", ", ");

            return sense;
        }
        public string GetMonsterLanguages(string apiResponse)
        {

            string Languages = Regex.Match(apiResponse, "languages\":.+?\",").Value; ;

            Languages = Regex.Replace(Languages, "\",", "");
            Languages = Regex.Replace(Languages, "\"", "");
            Languages = Regex.Replace(Languages, "languages:", "");
            Languages = Regex.Replace(Languages, ",", ", ");

            return Languages;
        }
        public string GetMonsterChallenge(string apiResponse)
        {

            string Challenge = Regex.Match(apiResponse, "challenge_rating\":.+?,").Value;
            string XP = Regex.Match(apiResponse, "xp\":.+?,").Value;

            Challenge = Regex.Replace(Challenge, ",", "");
            Challenge = Regex.Replace(Challenge, "\"", "");
            Challenge = Regex.Replace(Challenge, "challenge_rating:", "");

            XP = Regex.Replace(XP, ",", "");
            XP = Regex.Replace(XP, "\"", "");
            XP = Regex.Replace(XP, "xp:", "");

            if(XP.Length >= 4)
            {
                char[] charArray = XP.ToCharArray();
                Array.Reverse(charArray);
                int i = 1;
                XP = "";
                foreach (var c in charArray)
                {
                    XP = c + XP;
                    if (i % 3 == 0 && i != charArray.Length)
                    {
                        XP = "," + XP;
                    }

                    i++;
                }
            }

            return Challenge + $" ({XP} XP)";
        }
        public List<ActionModel> GetMonsterAbilities(string apiResponse)
        {
            List<ActionModel> abilities = new();
            string ability = Regex.Match(apiResponse, "special_abilities\":.+?\\]").Value;

            String[] list = ability.Split("},", StringSplitOptions.RemoveEmptyEntries);


            foreach (var p in list)
            {
                ActionModel a = new();
                string aname = Regex.Match(p, "name\":.+?\"").Value;

                aname = Regex.Replace(aname, "\"", "");
                aname = Regex.Replace(aname, "name:", "");

                a.Name = aname;

                string adesc = Regex.Match(p, "desc\":.+?\"").Value;

                adesc = Regex.Replace(adesc, "\"", "");
                adesc = Regex.Replace(adesc, "desc:", "");

                a.Description = adesc;

                if (a.Name != "" && a.Description != "")
                {
                    abilities.Add(a);
                }

            }

            return abilities;
        }
        public List<ActionModel> GetMonsterAction(string apiResponse)
        {
            List<ActionModel> actions = new();
            string action = Regex.Match(apiResponse, "actions\":.+?\\],").Value;

            String[] list = action.Split("]},", StringSplitOptions.RemoveEmptyEntries);


            foreach (var p in list)
            {
                ActionModel a = new();
                string aname = Regex.Match(p, "name\":.+?\"").Value;

                aname = Regex.Replace(aname, "\"", "");
                aname = Regex.Replace(aname, "name:", "");

                a.Name = aname;

                string adesc = Regex.Match(p, "desc\":.+?\"").Value;

                adesc = Regex.Replace(adesc, "\"", "");
                adesc = Regex.Replace(adesc, "desc:", "");

                a.Description = adesc;

                if (a.Name != "" && a.Description != "")
                {
                    actions.Add(a);
                }
            }

            return actions;
        }
        public List<ActionModel> GetMonsterLegendaryAction(string apiResponse)
        {
            List<ActionModel> actions = new();
            string action = Regex.Match(apiResponse, "legendary_actions\":.+?\\],").Value;

            String[] list = action.Split("},", StringSplitOptions.RemoveEmptyEntries);


            foreach (var p in list)
            {
                ActionModel a = new();
                string aname = Regex.Match(p, "name\":.+?\"").Value;

                aname = Regex.Replace(aname, "\"", "");
                aname = Regex.Replace(aname, "name:", "");

                a.Name = aname;

                string adesc = Regex.Match(p, "desc\":.+?\"").Value;

                adesc = Regex.Replace(adesc, "\"", "");
                adesc = Regex.Replace(adesc, "desc:", "");

                a.Description = adesc;

                if (a.Name != "" && a.Description != "")
                {
                    actions.Add(a);
                }
            }

            return actions;
        }

        public async Task AddMonster(MonsterItem mItem)
        {
            MonsterTemplate m = mItem.Monster;
            Monster toAdd = new();
            toAdd.LocationID = LocationId;
            toAdd.Name = m.Name;
            toAdd.Size = m.Size;
            toAdd.Type = m.Type;
            toAdd.SubType = m.SubType;
            toAdd.Alignment = m.Alignment;
            toAdd.ArmorClass = m.ArmorClass;
            toAdd.HitPoints = m.HitPoints;
            toAdd.HitDice = m.HitDice;
            toAdd.Speed = m.Speed;
            toAdd.Strength = m.Strength;
            toAdd.Dexterity = m.Dexterity;
            toAdd.Constitution = m.Constitution;
            toAdd.Intelligence = m.Intelligence;
            toAdd.Wisdom = m.Wisdom;
            toAdd.Charisma = m.Charisma;
            toAdd.SavingThrows = m.SavingThrows;
            toAdd.Skills = m.Skills;
            toAdd.DamageVulnerabilities = m.DamageVulnerabilities;
            toAdd.DamageResistances = m.DamageResistances;
            toAdd.DamageImmunities = m.DamageImmunities;
            toAdd.ConditionImmunities = m.ConditionImmunities;
            toAdd.Senses = m.Senses;
            toAdd.Languages = m.Languages;
            toAdd.Challange = m.Challange;
            await monsterService.Insert(toAdd);

            //Do stuff with Actions etc here!
        }
    }
    public class ActionModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class MonsterItem
    {
        public MonsterTemplate Monster = new();
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string apiResponse { get; set; }
        public bool hidden = true;
        public List<ActionModel> AbilityList = new();
        public List<ActionModel> ActionList = new();
        public List<ActionModel> LegendaryActionList = new();
    }
}
