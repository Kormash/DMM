using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey ("Campaign")]
        public int CampaignID { get; set; }
        public Campaign Campaign { get; set; }
    }
}
