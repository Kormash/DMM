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
using Microsoft.AspNetCore.Components.Web;

namespace DMM.Pages.AreaPages
{
    public partial class AreaView : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }
        [Inject]
        LocationService locationService { get; set; }
        [Inject]
        AreaService areaService { get; set; }
        //Variables
        string Output = "Temp Text";
        string LocationName = "New Location";
        string LocationDescription = "";

        bool HideCancel = true;
        bool LocationChoosen = false;
        Location CurrentLocation { get; set; }
        Area area = new();
        List<Location> LocationList = new();

        List<Dice> d100List = new();
        List<Dice> d20List = new();
        List<Dice> d12List = new();
        List<Dice> d10List = new();
        List<Dice> d8List = new();
        List<Dice> d6List = new();
        List<Dice> d4List = new();

        int d100toRoll = 0;
        int d20toRoll = 0;
        int d12toRoll = 0;
        int d10toRoll = 0;
        int d8toRoll = 0;
        int d6toRoll = 0;
        int d4toRoll = 0;

        bool HideD100Count = true;
        bool HideD20Count = true;
        bool HideD12Count = true;
        bool HideD10Count = true;
        bool HideD8Count = true;
        bool HideD6Count = true;
        bool HideD4Count = true;

        DiceModel diceModel = new();

        [Parameter]
        public int AreaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            LocationList = await locationService.GetLocationByAreaID(AreaId);
            area = await areaService.GetAreaByID(AreaId);
        }

        public void AddD100()
        {
            d100toRoll++;
            HideD100Count = false;
        }
        public void SubtractD100()
        {
            if (d100toRoll > 0)
            {
                d100toRoll--;
            }
            if (d100toRoll == 0)
            {
                HideD100Count = true;
            }
        }
        public void AddD20()
        {
            d20toRoll++;
            HideD20Count = false;
        }
        public void SubtractD20()
        {
            if (d20toRoll > 0)
            { 
                d20toRoll--;
            }
            if (d20toRoll == 0)
            {
                HideD20Count = true;
            }
        }
        public void AddD12()
        {
            d12toRoll++;
            HideD12Count = false;
        }
        public void SubtractD12()
        {
            if (d12toRoll > 0)
            {
                d12toRoll--;
            }
            if (d12toRoll == 0)
            {
                HideD12Count = true;
            }
        }
        public void AddD10()
        {
            d10toRoll++;
            HideD10Count = false;
        }
        public void SubtractD10()
        {
            if (d10toRoll > 0)
            {
                d10toRoll--;
            }
            if (d10toRoll == 0)
            {
                HideD10Count = true;
            }
        }
        public void AddD8()
        {
            d8toRoll++;
            HideD8Count = false;
        }
        public void SubtractD8()
        {
            if (d8toRoll > 0)
            {
                d8toRoll--;
            }
            if (d8toRoll == 0)
            {
                HideD8Count = true;
            }
        }
        public void AddD6()
        {
            d6toRoll++;
            HideD6Count = false;
        }
        public void SubtractD6()
        {
            if (d6toRoll > 0)
            {
                d6toRoll--;
            }
            if (d6toRoll == 0)
            {
                HideD6Count = true;
            }
        }
        public void AddD4()
        {
            d4toRoll++;
            HideD4Count = false;
        }
        public void SubtractD4()
        {
            if (d4toRoll > 0)
            {
                d4toRoll--;
            }
            if (d4toRoll == 0)
            {
                HideD4Count = true;
            }
        }

        public async Task RollDice()
        {
            
            if(d100toRoll != 0)
            {
                await DiceAPICall(d100toRoll, 100);
                await UpdateModel();
                HideCancel = false;
            }
            if (d20toRoll != 0)
            {
                await DiceAPICall(d20toRoll, 20);
                await UpdateModel();
                HideCancel = false;
            }
            if (d12toRoll != 0)
            {
                await DiceAPICall(d12toRoll, 12);
                await UpdateModel();
                HideCancel = false;
            }
            if (d10toRoll != 0)
            {
                await DiceAPICall(d10toRoll, 10);
                await UpdateModel();
                HideCancel = false;
            }
            if (d8toRoll != 0)
            {
                await DiceAPICall(d8toRoll, 8);
                await UpdateModel();
                HideCancel = false;
            }
            if (d6toRoll != 0)
            {
                await DiceAPICall(d6toRoll, 6);
                await UpdateModel();
                HideCancel = false;
            }
            if (d4toRoll != 0)
            {
                await DiceAPICall(d4toRoll, 4);
                await UpdateModel();
                HideCancel = false;
            }

            HideD100Count = true;
            HideD20Count = true;
            HideD12Count = true;
            HideD10Count = true;
            HideD8Count = true;
            HideD6Count = true;
            HideD4Count = true;

            d100toRoll = 0;
            d20toRoll = 0;
            d12toRoll = 0;
            d10toRoll = 0;
            d8toRoll = 0;
            d6toRoll = 0;
            d4toRoll = 0;


        }
        public async Task ClearDices()
        {
            HideCancel = true;
            d100List = new();
            d20List = new();
            d12List = new();
            d10List = new();
            d8List = new();
            d6List = new();
            d4List = new();
        }
        public async Task DiceAPICall(int diceNumber, int diceType)
        {
            try
            {
                HttpResponseMessage response = await Http.GetAsync($"https://localhost:44327/Dice/{diceNumber}/{diceType}");
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
        public async Task UpdateModel()
        {
            String[] DiceStrings = Output.Split(",", StringSplitOptions.RemoveEmptyEntries);

            string diceTypeString = Regex.Replace(DiceStrings[0], "\\[\\{\"diceType\":", "");
            diceModel.DiceType = int.Parse(diceTypeString);

            string diceNumberString = Regex.Replace(DiceStrings[1], "\"diceNumber\":", "");
            diceModel.DiceNumber = int.Parse(diceNumberString);

            string diceSumString = Regex.Replace(DiceStrings[2], "\"diceSum\":", "");
            diceModel.DiceSum = int.Parse(diceSumString);

            string resultString = Regex.Replace(DiceStrings[3], "\"", "");
            resultString = Regex.Replace(resultString, "resultString:", "");
            resultString = Regex.Replace(resultString, "\\}\\]", "");
            diceModel.ResultString = resultString;

            String[] DiceResults = resultString.Split(" + ", StringSplitOptions.RemoveEmptyEntries);
            foreach(var result in DiceResults)
            {
                Dice d = new();
                d.DiceType = diceModel.DiceType;
                d.DiceResult = int.Parse(result);

                if(d.DiceType == 100)
                {
                    d100List.Add(d);
                }
                else if(d.DiceType == 20)
                {
                    d20List.Add(d);
                }
                else if (d.DiceType == 12)
                {
                    d12List.Add(d);
                }
                else if (d.DiceType == 10)
                {
                    d10List.Add(d);
                }
                else if (d.DiceType == 8)
                {
                    d8List.Add(d);
                }
                else if (d.DiceType == 6)
                {
                    d6List.Add(d);
                }
                else if (d.DiceType == 4)
                {
                    d4List.Add(d);
                }
            }

            d100List = d100List.OrderByDescending(x => x.DiceResult).ToList();
            d20List = d20List.OrderByDescending(x => x.DiceResult).ToList();
            d12List = d12List.OrderByDescending(x => x.DiceResult).ToList();
            d10List = d10List.OrderByDescending(x => x.DiceResult).ToList();
            d8List = d8List.OrderByDescending(x => x.DiceResult).ToList();
            d6List = d6List.OrderByDescending(x => x.DiceResult).ToList();
            d4List = d4List.OrderByDescending(x => x.DiceResult).ToList();

        }
        public async Task RemoveDice(Dice dice)
        {
            switch (dice.DiceType)
            {
                case 100:
                    d100List.Remove(dice);
                    break;
                case 20:
                    d20List.Remove(dice);
                    break;
                case 12:
                    d12List.Remove(dice);
                    break;
                case 10:
                    d10List.Remove(dice);
                    break;
                case 8:
                    d8List.Remove(dice);
                    break;
                case 6:
                    d6List.Remove(dice);
                    break;
                case 4:
                    d4List.Remove(dice);
                    break;
            }

            if(d100List.Count() == 0 && d20List.Count() == 0 && d12List.Count() == 0 && d10List.Count() == 0 && d8List.Count() == 0 && d6List.Count() == 0 && d4List.Count() == 0)
            {
                HideCancel = true;
            }

        }
        public async Task AddLocation(string LocationName)
        {
            Location l = new();
            l.Name = LocationName;
            l.Description = LocationDescription;
            l.AreaID = AreaId;

            LocationName = "New Location";
            LocationDescription = "";

            await locationService.Insert(l);
            LocationList = await locationService.GetLocationByAreaID(AreaId);
            this.StateHasChanged();
        }
        public void ChooseLocation(Location l)
        {
            LocationChoosen = true;
            CurrentLocation = l;
        }
        public void Back()
        {
            LocationChoosen = false;
        }
    }
    public class DiceModel
    {
        public int DiceType { get; set; }

        public int DiceNumber { get; set; }

        public int DiceSum { get; set; }

        public string ResultString { get; set; }
    }

    public class Dice 
    {
        public int DiceType { get; set; }
        public int DiceResult { get; set; }
    }
}
