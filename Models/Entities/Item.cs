using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GPValue { get; set; }
        public int Weight { get; set; }
        public string Rarity { get; set; }

        //public picture? Image { get; set; }

        [ForeignKey("Loot")]
        public int LootID { get; set; }
        public Loot Loot { get; set; }
    }
}
