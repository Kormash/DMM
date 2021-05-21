using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class AttatchedFile
    {
        public int Id { get; set; }

        //public picture? Image { get; set; }

        [ForeignKey("Note")]
        public int NoteID { get; set; }
        public Note Note { get; set; }
    }
}
