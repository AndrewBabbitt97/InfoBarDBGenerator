using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharEffects
    {
        public int Charid { get; set; }
        public short Effectid { get; set; }
        public short Icon { get; set; }
        public short Power { get; set; }
        public int Tick { get; set; }
        public int Duration { get; set; }
        public short Subid { get; set; }
        public short Subpower { get; set; }
        public short Tier { get; set; }
        public int Trashid { get; set; }
    }
}
