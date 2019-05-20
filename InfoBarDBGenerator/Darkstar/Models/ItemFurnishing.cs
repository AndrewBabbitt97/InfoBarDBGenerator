using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemFurnishing
    {
        public short Itemid { get; set; }
        public string Name { get; set; }
        public byte Storage { get; set; }
        public short Moghancement { get; set; }
        public byte Element { get; set; }
        public byte Aura { get; set; }
    }
}
