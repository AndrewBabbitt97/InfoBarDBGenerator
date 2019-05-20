using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class PetList
    {
        public int Petid { get; set; }
        public string Name { get; set; }
        public int Poolid { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public int Time { get; set; }
        public byte Element { get; set; }
    }
}
