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
using Syncfusion.Blazor.RichTextEditor;
using BlazorInputFile;
using System.IO;
using DMM.Pages.Shared;

namespace DMM.Pages.AreaPages
{
    public partial class AreaView : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }
        [Inject]
        LocationService locationService { get; set; }
        [Inject]
        CampaignService campaignService { get; set; }
        [Inject]
        AreaService areaService { get; set; }
        [Inject]
        NoteService noteService { get; set; }
        [Inject]
        MapService mapService { get; set; }
        [Inject]
        MonsterService monsterService { get; set; }
        [Inject]
        TraitService traitService { get; set; }
        [Inject]
        MonsterActionService monsterActionService { get; set; }
        [Inject]
        UserManager<IdentityUser> UserManager { get; set; }
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        //Variables
        string Output = "Temp Text";
        string LocationName = "New Location";
        string LocationDescription = "";
        string NoteTitle = "New Note";
        string MapTitle = "New Map";
        MapImageModel MapImageModel = new();
        SharedMethods SharedMethods = new();

        public List<MonsterTemplate> monsterAddList = new();

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

        private MarkupString convertedMarkdownDescription { get; set; }



        bool HideCancel = true;
        bool LocationChoosen = false;
        bool editDescription = false;
        Location CurrentLocation { get; set; }
        Area area = new();
        List<Location> LocationList = new();
        List<NoteModel> NoteList = new();
        List<MapModel> MapList = new();
        List<Initiative> InitiativeList = new();
        string InitiativeName = "";
        int InitiativeRoll = 0;
        int InitiativeHP = 0;
        FocusObject focusObject = new();

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

        bool CanEdit = false;

        DiceModel diceModel = new();
        public bool MonsterModal = false;
        List<MonsterObject> MonsterList = new();
        Campaign campaign = new();

        [Parameter]
        public int AreaId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            LocationList = await locationService.GetLocationByAreaID(AreaId);
            area = await areaService.GetAreaByID(AreaId);
            campaign = await campaignService.GetCampaignByID(area.CampaignID);

            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user.Identity.IsAuthenticated)
            {
                var currentUser = await UserManager.GetUserAsync(user);
                if (currentUser.Id == campaign.UserId)
                {
                    CanEdit = true;
                }
            }
            else
            {
                CanEdit = false;
            }

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
                UpdateModel();
                HideCancel = false;
            }
            if (d20toRoll != 0)
            {
                await DiceAPICall(d20toRoll, 20);
                UpdateModel();
                HideCancel = false;
            }
            if (d12toRoll != 0)
            {
                await DiceAPICall(d12toRoll, 12);
                UpdateModel();
                HideCancel = false;
            }
            if (d10toRoll != 0)
            {
                await DiceAPICall(d10toRoll, 10);
                UpdateModel();
                HideCancel = false;
            }
            if (d8toRoll != 0)
            {
                await DiceAPICall(d8toRoll, 8);
                UpdateModel();
                HideCancel = false;
            }
            if (d6toRoll != 0)
            {
                await DiceAPICall(d6toRoll, 6);
                UpdateModel();
                HideCancel = false;
            }
            if (d4toRoll != 0)
            {
                await DiceAPICall(d4toRoll, 4);
                UpdateModel();
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
        public void ClearDices()
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
        public void UpdateModel()
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
        public void RemoveDice(Dice dice)
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
        public async Task ChooseLocation(Location l)
        {
            LocationChoosen = true;
            CurrentLocation = l;
            ConvertToMarkdownDescription();
            await UpdateNoteList();
            await UpdateMapList();
            await UpdateMonsterList();
            
        }

        public async Task UpdateMonsterList()
        {
            MonsterList = new();
            var mList = await monsterService.GetMonstersByLocationId(CurrentLocation.Id);
            foreach(var m in mList)
            {
                MonsterObject toAdd = new();
                toAdd.Monster = m;
                toAdd.AbilityList = await traitService.GetTraitsByMonsterId(m.Id);
                var actionList = await monsterActionService.GetMonsterActionsByMonsterId(m.Id);
                foreach(var a in actionList)
                {
                    if (a.IsLegendary)
                    {
                        toAdd.LegendaryActionList.Add(a);
                    }
                    else
                    {
                        toAdd.ActionList.Add(a);
                    }
                }
                MonsterList.Add(toAdd);

            }
        }
        public void Back()
        {
            LocationChoosen = false;
        }

        public void AddInitiative()
        {
            Initiative i = new();
            i.Name = InitiativeName;
            i.Roll = InitiativeRoll;
            i.HP = InitiativeHP;
            i.IsCurrent = false;

            if(InitiativeList.Count == 0 || InitiativeList.First().IsCurrent == false)
            {
                InitiativeList.Add(i);
            }
            else
            {
                int index = 0;
                foreach (var initiative in InitiativeList)
                {
                    if(InitiativeList.Max(x => x.Roll) > i.Roll && InitiativeList.Min(x => x.Roll) < i.Roll)
                    {
                        index = InitiativeList.FindIndex(x => x == initiative);
                        if(initiative.Roll > i.Roll && (InitiativeList.Count() < index+2 || InitiativeList[index+1].Roll <= i.Roll))
                        {
                            index++;
                            break;
                        }
                    }
                    else
                    {
                        if (InitiativeList.Max(x => x.Roll) <= i.Roll && initiative.Roll == InitiativeList.Max(x => x.Roll))
                        {
                            index = InitiativeList.FindIndex(x => x == initiative);
                            break;
                        }
                        if (InitiativeList.Min(x => x.Roll) >= i.Roll && initiative.Roll == InitiativeList.Min(x => x.Roll))
                        {
                            index = InitiativeList.FindIndex(x => x == initiative) + 1;
                            break;
                        }
                    } 

                }
                if(index < InitiativeList.Count && index != 0)
                {
                    InitiativeList.Insert(index, i);
                }
                else
                {
                    InitiativeList.Add(i);
                }
                
            }
            

            InitiativeName = "";
            InitiativeRoll = 0;
        }

        public void RemoveInitiative(Initiative i)
        {
            InitiativeList.Remove(i);
            if (i.IsCurrent == true && InitiativeList.Count > 0)
            {
                InitiativeList.First().IsCurrent = true;
            }
        }

        public void SortInitiative()
        {
            if(InitiativeList.Count > 0)
            {
                InitiativeList = InitiativeList.OrderBy(x => x.Roll).Reverse().ToList();
                foreach (var i in InitiativeList)
                {
                    i.IsCurrent = false;
                }
                InitiativeList.First().IsCurrent = true;
            }
            
        }

        public void NextInitiative()
        {
            if (InitiativeList.Count > 0)
            {
                Initiative i = InitiativeList.First();
                InitiativeList.Remove(i);
                i.IsCurrent = false;
                InitiativeList.Add(i);
                InitiativeList.First().IsCurrent = true;
            }       
        }

        public void ClearInitiative()
        {
            InitiativeList = new();
        }

        public void EditDescription()
        {
            editDescription = true;
        }

        public void AbortEditDescription(Location currentLocation)
        {
            editDescription = false;
            currentLocation.Description = convertedMarkdownDescription.ToString();
        }

        public async Task SaveDescription(Location currentLocation)
        {
            await locationService.Update(currentLocation);
            ConvertToMarkdownDescription();
            editDescription = false;
        }

        public void ConvertToMarkdownDescription()
        {
            // Required Markdig https://www.nuget.org/packages/Markdig/
            if (CurrentLocation != null)
            {
                var html = Markdig.Markdown.ToHtml(CurrentLocation.Description ?? "");
                convertedMarkdownDescription = (MarkupString)html; // or new MarkupString(html)
            }
        }

        public async Task AddNote()
        {
            Note n = new();
            n.Title = NoteTitle;
            n.LocationID = CurrentLocation.Id;

            NoteTitle = "New Note";

            await noteService.Insert(n);
            await UpdateNoteList();
            this.StateHasChanged();
        }

        public void ChooseNote(NoteModel n)
        {
            n.hidden = !n.hidden;
            ConvertToMarkdownNote(n);
        }

        public async Task DeleteNote(NoteModel n)
        {
            await noteService.DeleteNote(n.note);
            await UpdateNoteList();
        }

        public async Task UpdateNoteList()
        {
            List<Note> noteList = await noteService.GetNotesByLocationID(CurrentLocation.Id);
            NoteList = new();
            foreach(var note in noteList)
            {
                NoteModel n = new();
                n.note = note;
                NoteList.Add(n);
            }

        }

        public void ConvertToMarkdownNote(NoteModel noteModel)
        {
            // Required Markdig https://www.nuget.org/packages/Markdig/
            if (CurrentLocation != null)
            {
                var html = Markdig.Markdown.ToHtml(noteModel.note.Text ?? "");
                noteModel.markup = (MarkupString)html; // or new MarkupString(html)
            }
        }

        public void EditNote(NoteModel currentNote)
        {
            currentNote.edit = true;
            currentNote.Title = currentNote.note.Title;
        }

        public void AbortEditNote(NoteModel currentNote)
        {
            currentNote.edit = false;
            currentNote.note.Text = currentNote.markup.ToString();
        }

        public async Task SaveNote(NoteModel currentNote)
        {
            currentNote.note.Title = currentNote.Title;
            await noteService.Update(currentNote.note);
            ConvertToMarkdownNote(currentNote);
            currentNote.edit = false;
        }

        public async Task AddMap ()
        {
            Map m = new();
            m.Title = MapTitle;
            m.LocationID = CurrentLocation.Id;

            MapTitle = "New Map";

            await mapService.Insert(m);
            await UpdateMapList();
            this.StateHasChanged();
        }

        public async Task UpdateMapList()
        {
            List<Map> mapList = await mapService.GetMapsByLocationID(CurrentLocation.Id);
            MapList = new();
            foreach (var map in mapList)
            {
                MapModel m = new();
                m.Map = map;
                MapList.Add(m);
            }

        }

        public void ChooseMap(MapModel m)
        {
            m.hidden = !m.hidden;
        }

        public async Task RemoveMap(Map m)
        {
            await mapService.DeleteMap(m);
            await UpdateMapList();
            this.StateHasChanged();
        }

        async Task HandleSelection(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file.Name.EndsWith(".jpg") || file.Name.EndsWith(".png"))
            {
                var ms = new MemoryStream();
                await file.Data.CopyToAsync(ms);
                MapImageModel.Image = ms.ToArray();
            }
        }

        public string ConvertImage(byte[] Image)
        {
            return SharedMethods.ConvertImageToDisplay(Image);
        }

        public async Task SaveMap()
        {
            Map m = new();
            m.Image = MapImageModel.Image;
            m.Title = MapImageModel.Title;
            m.LocationID = CurrentLocation.Id;
            await mapService.Insert(m);
            await UpdateMapList();
            this.StateHasChanged();
        }

        public void FocusMap(Map m)
        {
            focusObject = new();
            focusObject.Title = m.Title;
            focusObject.Image = m.Image;
        }

        public void AddMonster()
        {
            MonsterModal = true;
        }

        public async Task SaveMonster()
        {
            await UpdateMonsterList();
            this.StateHasChanged();
            MonsterModal = false;
        }

        public int GetModifier(int stat)
        {
            double statDouble = stat;
            return (int)Math.Floor((statDouble - 10) / 2);
        }

        public void ShowMonster(MonsterObject m)
        {
            m.hidden = !m.hidden;
        }

        public void SelectMonster(MonsterObject m)
        {
            focusObject = new();
            focusObject.Title = m.Monster.Name;
            focusObject.MonsterObj = m;
        }

        public async Task DeleteMonster(MonsterObject m)
        {
            await monsterService.DeleteMonster(m.Monster);
            await UpdateMonsterList();
            this.StateHasChanged();
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

    public class Initiative
    {
        public string Name { get; set; }
        public int Roll { get; set; }

        public int HP { get; set; }
        public bool IsCurrent { get; set; }


    }

    public class NoteModel
    {
        public Note note { get; set; }
        public bool hidden = true;
        public bool edit = false;
        public string Title { get; set; }
        public MarkupString markup { get; set; }
    }

    public class MapModel
    {
        public Map Map { get; set; }
        public bool hidden = true;
    }

    public class MapImageModel
    {
        public string Title { get; set; }
        public byte[] Image { get; set; }
    }

    public class FocusObject
    {
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public MonsterObject MonsterObj { get; set; }
    }

    public class MonsterObject
    {
        public Monster Monster { get; set; }
        public bool hidden = true;
        public List<Trait> AbilityList = new();
        public List<MonsterAction> ActionList = new();
        public List<MonsterAction> LegendaryActionList = new();
    }
}
