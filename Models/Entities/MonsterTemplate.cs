using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class MonsterTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Alignment { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public string HitDice { get; set; }
        public string Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public string SavingThrows { get; set; }
        public string Skills { get; set; }
        public string DamageVulnerabilities { get; set; }
        public string DamageResistances { get; set; }
        public string DamageImmunities { get; set; }
        public string ConditionImmunities { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        public string Challange { get; set; }
    }
}
