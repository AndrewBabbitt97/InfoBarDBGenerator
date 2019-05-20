using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemPuppet
    {
        public short Itemid { get; set; }
        public string Name { get; set; }
        public byte Slot { get; set; }
        public int Element { get; set; }
    }
}
