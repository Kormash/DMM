using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Models.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string UserId { get; set; }
        public bool IsPublic { get; set; }
    }
}
