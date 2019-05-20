using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemArmor
    {
        public short ItemId { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public byte Ilevel { get; set; }
        public int Jobs { get; set; }
        public short Mid { get; set; }
        public byte ShieldSize { get; set; }
        public short ScriptType { get; set; }
        public short Slot { get; set; }
        public short Rslot { get; set; }
    }
}
