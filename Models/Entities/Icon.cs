using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Icon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
