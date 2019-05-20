using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Merits
    {
        public short Meritid { get; set; }
        public string Name { get; set; }
        public byte Upgrade { get; set; }
        public short Value { get; set; }
        public int Jobs { get; set; }
        public byte Upgradeid { get; set; }
        public byte Catagoryid { get; set; }
    }
}
