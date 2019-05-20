using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharSkills
    {
        public int Charid { get; set; }
        public byte Skillid { get; set; }
        public short Value { get; set; }
        public byte Rank { get; set; }
    }
}
