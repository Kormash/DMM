using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Trait
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Monster")]
        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
