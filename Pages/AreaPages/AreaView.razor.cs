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
        int diceType = 20;
        int diceNumber = 1;

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

        DiceModel diceModel = new();

        [Parameter]
        public int AreaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
        }

        public void AddD100()
        {
            d100toRoll++;
        }
        public void AddD20()
        {
            d20toRoll++;
        }
        public void AddD12()
        {
            d12toRoll++;
        }
        public void AddD10()
        {
            d10toRoll++;
        }
        public void AddD8()
        {
            d8toRoll++;
        }
        public void AddD6()
        {
            d6toRoll++;
        }
        public void AddD4()
        {
            d4toRoll++;
        }

        public async Task RollDice()
        {
            if(d100toRoll != 0)
            {
                await DiceAPICall(d100toRoll, 100);
                await UpdateModel();
            }
            if (d20toRoll != 0)
            {
                await DiceAPICall(d20toRoll, 20);
                await UpdateModel();
            }
            if (d12toRoll != 0)
            {
                await DiceAPICall(d12toRoll, 12);
                await UpdateModel();
            }
            if (d10toRoll != 0)
            {
                await DiceAPICall(d10toRoll, 10);
                await UpdateModel();
            }
            if (d8toRoll != 0)
            {
                await DiceAPICall(d8toRoll, 8);
                await UpdateModel();
            }
            if (d6toRoll != 0)
            {
                await DiceAPICall(d6toRoll, 6);
                await UpdateModel();
            }
            if (d4toRoll != 0)
            {
                await DiceAPICall(d4toRoll, 4);
                await UpdateModel();
            }

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
