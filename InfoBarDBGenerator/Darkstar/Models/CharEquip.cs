using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharEquip
    {
        public int Charid { get; set; }
        public byte Slotid { get; set; }
        public byte Equipslotid { get; set; }
        public byte Containerid { get; set; }
    }
}
