using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Map
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //public picture? Image { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
