using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemBasic
    {
        public int Itemid { get; set; }
        public int Subid { get; set; }
        public string Name { get; set; }
        public string Sortname { get; set; }
        public byte StackSize { get; set; }
        public int Flags { get; set; }
        public byte AH { get; set; }
        public byte NoSale { get; set; }
        public int BaseSell { get; set; }
    }
}
