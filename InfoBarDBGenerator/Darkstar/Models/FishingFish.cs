using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class FishingFish
    {
        public int Fishid { get; set; }
        public string Name { get; set; }
        public byte Min { get; set; }
        public byte Max { get; set; }
        public byte Watertype { get; set; }
        public byte Size { get; set; }
        public byte Stamina { get; set; }
        public byte Log { get; set; }
        public byte Quest { get; set; }
    }
}
