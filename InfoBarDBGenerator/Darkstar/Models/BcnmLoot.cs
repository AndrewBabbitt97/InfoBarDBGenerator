using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BcnmLoot
    {
        public short LootDropId { get; set; }
        public short ItemId { get; set; }
        public short Rolls { get; set; }
        public byte LootGroupId { get; set; }
        public int Trashid { get; set; }
    }
}
