using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class FishingLure
    {
        public short Lureid { get; set; }
        public string Name { get; set; }
        public short Fishid { get; set; }
        public short Luck { get; set; }
    }
}
