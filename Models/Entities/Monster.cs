using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Race { get; set; }
        public string Allignment { get; set; }
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }
        public string Speed { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public string SavingThrows { get; set; }
        public string Skills { get; set; }
        public string DamageWeakness { get; set; }
        public string DamageResistance { get; set; }
        public string DamageImmunity { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        public string Challange { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
