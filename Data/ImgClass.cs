using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMM.Data
{
    public class ImgClass
    {
        [Key]
        public int ImgId { get; set; }
        public string ImgName { get; set; }
        public byte[] Img { get; set; }
    }
}
