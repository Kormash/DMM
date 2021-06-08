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

        DiceModel diceModel = new();

        [Parameter]
        public int AreaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
        }

        public async Task RollDice()
        {
            await DiceAPICall(diceNumber, diceType);
            await UpdateModel();
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
