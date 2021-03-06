#pragma checksum "D:\repos\DMM\Pages\Shared\MonsterDiv.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c63dd3ad31ce8b1751ff9f85fa75df98437e7b5"
// <auto-generated/>
#pragma warning disable 1591
namespace DMM.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\DMM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\DMM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\DMM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\DMM\_Imports.razor"
using DMM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\DMM\_Imports.razor"
using DMM.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\repos\DMM\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\repos\DMM\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
using Blazority;

#line default
#line hidden
#nullable disable
    public partial class MonsterDiv : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "padding-top:12px; margin:auto; width:80%;");
#nullable restore
#line 5 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
     foreach (var m in MonsterList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "MonsterDivSize hoverOutline");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                           () => MonsterDetails(m)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "margin-top:6px;");
            __builder.OpenElement(7, "div");
            __builder.OpenElement(8, "b");
            __builder.AddAttribute(9, "style", "color:black;");
            __builder.AddContent(10, 
#nullable restore
#line 10 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             m.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 14 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
         if(m.hidden == false)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "AddMonster");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                              () => AddMonster(m)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(14, "t");
            __builder.AddContent(15, 
#nullable restore
#line 17 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    TempOutput

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "hidden", 
#nullable restore
#line 20 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                      m.hidden

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(18, "class", "MonsterDivContainer");
            __builder.AddMarkupContent(19, "<div class=\"MonsterDivTop\"></div>\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "background-image: url(\'/images/parchment.png\');margin-right:24px;margin-left:24px;");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "MonsterChunkDiv");
            __builder.OpenElement(24, "h1");
            __builder.AddAttribute(25, "style", "letter-spacing:1px;font-family:ModestoBold;font-variant:small-caps;color:#822000;margin:0");
            __builder.AddContent(26, 
#nullable restore
#line 24 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                           m.Monster.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "style", "font-family:Cambria;color:black;margin:0");
            __builder.OpenElement(30, "i");
            __builder.AddContent(31, 
#nullable restore
#line 27 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                             m.Monster.Size

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.AddContent(33, 
#nullable restore
#line 28 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                             m.Monster.Type

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 29 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                             if (m.Monster.SubType != null && m.Monster.SubType != "")
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "i");
            __builder.AddContent(35, " (");
            __builder.AddContent(36, 
#nullable restore
#line 30 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                   m.Monster.SubType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " )");
            __builder.CloseElement();
#nullable restore
#line 30 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                            , ");
            __builder.AddContent(39, 
#nullable restore
#line 31 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                               m.Monster.Alignment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "MonsterChunkDiv");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(45, "<b>Armor Class </b>");
            __builder.AddContent(46, 
#nullable restore
#line 36 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                            m.Monster.ArmorClass

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(50, "<b>Hit Points </b>");
            __builder.AddContent(51, 
#nullable restore
#line 37 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                           m.Monster.HitPoints

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " (");
            __builder.AddContent(53, 
#nullable restore
#line 37 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                 m.Monster.HitDice

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "p");
            __builder.AddAttribute(57, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(58, "<b>Speed </b>");
            __builder.AddContent(59, 
#nullable restore
#line 38 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                      m.Monster.Speed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "MonsterChunkDiv");
            __builder.OpenElement(63, "table");
            __builder.AddAttribute(64, "style", "width:100%");
            __builder.AddMarkupContent(65, @"<tr><th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> STR</h5></th>
                            <th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> DEX</h5></th>
                            <th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> CON</h5></th>
                            <th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> INT</h5></th>
                            <th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> WIS</h5></th>
                            <th><h5 style=""font-family:ModestoRegular;color:#58170D;margin:0;text-align:center""> CHA</h5></th></tr>
                        ");
            __builder.OpenElement(66, "tr");
            __builder.OpenElement(67, "td");
            __builder.OpenElement(68, "h5");
            __builder.AddAttribute(69, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(70, 
#nullable restore
#line 65 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Strength

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " (");
#nullable restore
#line 65 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                          if (GetModifier(m.Monster.Strength) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<t>+</t>");
#nullable restore
#line 66 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, 
#nullable restore
#line 66 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Strength)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "td");
            __builder.OpenElement(77, "h5");
            __builder.AddAttribute(78, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(79, 
#nullable restore
#line 71 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Dexterity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(80, " (");
#nullable restore
#line 71 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                           if (GetModifier(m.Monster.Dexterity) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "<t>+</t>");
#nullable restore
#line 72 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, 
#nullable restore
#line 72 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Dexterity)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(83, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "h5");
            __builder.AddAttribute(87, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(88, 
#nullable restore
#line 77 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Constitution

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(89, " (");
#nullable restore
#line 77 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                              if (GetModifier(m.Monster.Constitution) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "<t>+</t>");
#nullable restore
#line 78 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, 
#nullable restore
#line 78 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Constitution)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(92, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.OpenElement(94, "td");
            __builder.OpenElement(95, "h5");
            __builder.AddAttribute(96, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(97, 
#nullable restore
#line 83 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Intelligence

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, " (");
#nullable restore
#line 83 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                              if (GetModifier(m.Monster.Intelligence) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "<t>+</t>");
#nullable restore
#line 84 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, 
#nullable restore
#line 84 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Intelligence)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(101, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.OpenElement(104, "h5");
            __builder.AddAttribute(105, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(106, 
#nullable restore
#line 89 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Wisdom

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(107, " (");
#nullable restore
#line 89 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                        if (GetModifier(m.Monster.Wisdom) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(108, "<t>+</t>");
#nullable restore
#line 90 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(109, 
#nullable restore
#line 90 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Wisdom)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "td");
            __builder.OpenElement(113, "h5");
            __builder.AddAttribute(114, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-align:center");
            __builder.AddContent(115, 
#nullable restore
#line 95 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                     m.Monster.Charisma

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(116, " (");
#nullable restore
#line 95 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                          if (GetModifier(m.Monster.Charisma) >= 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(117, "<t>+</t>");
#nullable restore
#line 96 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, 
#nullable restore
#line 96 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                               GetModifier(m.Monster.Charisma)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(119, ")\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "MonsterChunkDiv");
#nullable restore
#line 104 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.SavingThrows != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(123, "p");
            __builder.AddAttribute(124, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(125, "<b>Saving Throws </b>");
            __builder.OpenElement(126, "t");
            __builder.AddAttribute(127, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-transform:capitalize");
            __builder.AddContent(128, 
#nullable restore
#line 106 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                                        m.Monster.SavingThrows

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.Skills != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(129, "p");
            __builder.AddAttribute(130, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(131, "<b>Skills </b>");
            __builder.OpenElement(132, "t");
            __builder.AddAttribute(133, "style", "font-family:ModestoRegular;color:#58170D;margin:0;text-transform:capitalize");
            __builder.AddContent(134, 
#nullable restore
#line 110 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                                 m.Monster.Skills

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 111 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.DamageVulnerabilities != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(135, "p");
            __builder.AddAttribute(136, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(137, "<b>Damage Vulnerabilities </b>");
            __builder.OpenElement(138, "t");
            __builder.AddAttribute(139, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(140, "style", "text-transform:capitalize");
            __builder.AddContent(141, 
#nullable restore
#line 114 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                               m.Monster.DamageVulnerabilities

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.DamageResistances != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "p");
            __builder.AddAttribute(143, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(144, "<b>Damage Resistances </b>");
            __builder.OpenElement(145, "t");
            __builder.AddAttribute(146, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(147, "style", "text-transform:capitalize");
            __builder.AddContent(148, 
#nullable restore
#line 118 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                           m.Monster.DamageResistances

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 119 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.DamageImmunities != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(149, "p");
            __builder.AddAttribute(150, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(151, "<b>Damage Immunities </b>");
            __builder.OpenElement(152, "t");
            __builder.AddAttribute(153, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(154, "style", "text-transform:capitalize");
            __builder.AddContent(155, 
#nullable restore
#line 122 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                          m.Monster.DamageImmunities

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 123 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.ConditionImmunities != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(156, "p");
            __builder.AddAttribute(157, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(158, "<b>Condition Immunities </b>");
            __builder.OpenElement(159, "t");
            __builder.AddAttribute(160, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(161, "style", "text-transform:capitalize");
            __builder.AddContent(162, 
#nullable restore
#line 126 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                             m.Monster.ConditionImmunities

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 127 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.Senses != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(163, "p");
            __builder.AddAttribute(164, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(165, "<b>Senses </b>");
            __builder.OpenElement(166, "t");
            __builder.AddAttribute(167, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(168, "style", "text-transform:capitalize");
            __builder.AddContent(169, 
#nullable restore
#line 130 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                               m.Monster.Senses

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 131 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.Languages != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(170, "p");
            __builder.AddAttribute(171, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(172, "<b>Languages </b>");
            __builder.OpenElement(173, "t");
            __builder.AddAttribute(174, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(175, "style", "text-transform:capitalize");
            __builder.AddContent(176, 
#nullable restore
#line 134 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                  m.Monster.Languages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 135 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                     if (m.Monster.Challange != "")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(177, "p");
            __builder.AddAttribute(178, "class", "MonsterTextArialRegular");
            __builder.AddMarkupContent(179, "<b>Challenge </b>");
            __builder.OpenElement(180, "t");
            __builder.AddAttribute(181, "class", "MonsterTextArialRegular");
            __builder.AddAttribute(182, "style", "text-transform:capitalize");
            __builder.AddContent(183, 
#nullable restore
#line 138 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                  m.Monster.Challange

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 141 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                 if (m.AbilityList.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "class", "MonsterChunkDivMiddle");
#nullable restore
#line 144 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                         foreach (var a in m.AbilityList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(186, "p");
            __builder.AddAttribute(187, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.OpenElement(188, "i");
            __builder.OpenElement(189, "b");
            __builder.AddContent(190, 
#nullable restore
#line 146 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                        a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(191, "<t>.</t>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(192, " ");
            __builder.OpenElement(193, "t");
            __builder.AddAttribute(194, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.AddContent(195, 
#nullable restore
#line 146 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                                     a.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 147 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 149 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                 if (m.ActionList.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "MonsterChunkDivMiddle");
            __builder.AddMarkupContent(198, "<div class=\"MonsterChunkTitle\"><h5 style=\"letter-spacing:1px;font-family:Arial;font-variant:small-caps;color:#822000;margin:0\">Actions</h5></div>");
#nullable restore
#line 154 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                         foreach (var a in m.ActionList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(199, "p");
            __builder.AddAttribute(200, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.OpenElement(201, "i");
            __builder.OpenElement(202, "b");
            __builder.AddContent(203, 
#nullable restore
#line 156 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                        a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(204, "<t>.</t>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(205, " ");
            __builder.OpenElement(206, "t");
            __builder.AddAttribute(207, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.AddContent(208, 
#nullable restore
#line 156 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                                     a.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 157 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 159 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                 if (m.LegendaryActionList.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(209, "div");
            __builder.AddAttribute(210, "class", "MonsterChunkDivMiddle");
            __builder.AddMarkupContent(211, "<div class=\"MonsterChunkTitle\"><h5 style=\"letter-spacing:1px;font-family:Arial;font-variant:small-caps;color:#822000;margin:0\">Legendary Actions</h5></div>");
#nullable restore
#line 164 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                         foreach (var a in m.LegendaryActionList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(212, "p");
            __builder.AddAttribute(213, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.OpenElement(214, "i");
            __builder.OpenElement(215, "b");
            __builder.AddContent(216, 
#nullable restore
#line 166 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                        a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(217, "<t>.</t>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(218, " ");
            __builder.OpenElement(219, "t");
            __builder.AddAttribute(220, "style", "font-family:Georgia;color:black;margin:0;");
            __builder.AddContent(221, 
#nullable restore
#line 166 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                                                                                                                                                                     a.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 167 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 169 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n            <div class=\"MonsterDivBottom\"></div>");
            __builder.CloseElement();
#nullable restore
#line 173 "D:\repos\DMM\Pages\Shared\MonsterDiv.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
