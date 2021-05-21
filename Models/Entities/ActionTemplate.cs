using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class ActionTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DamageType { get; set; }
        public int ToHitDiceMod { get; set; }
        public int OnHitDiceType { get; set; }
        public int OnHitDiceNumber { get; set; }
        public int OnHitDiceMod { get; set; }

        [ForeignKey("MonsterTemplate")]
        public int MonsterTemplateID { get; set; }
        public MonsterTemplate MonsterTemplate { get; set; }
    }
}
