using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharLook
    {
        public int Charid { get; set; }
        public byte Face { get; set; }
        public byte Race { get; set; }
        public byte Size { get; set; }
        public short Head { get; set; }
        public short Body { get; set; }
        public short Hands { get; set; }
        public short Legs { get; set; }
        public short Feet { get; set; }
        public short Main { get; set; }
        public short Sub { get; set; }
        public short Ranged { get; set; }
    }
}
