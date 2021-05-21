using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class TraitTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("MonsterTemplate")]
        public int MonsterTemplateID { get; set; }
        public MonsterTemplate MonsterTemplate { get; set; }
    }
}
