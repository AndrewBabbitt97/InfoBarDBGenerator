using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharPet
    {
        public int Charid { get; set; }
        public short Wyvernid { get; set; }
        public short Automatonid { get; set; }
        public byte[] UnlockedAttachments { get; set; }
        public byte[] EquippedAttachments { get; set; }
        public short Adventuringfellowid { get; set; }
        public int Chocoboid { get; set; }
    }
}
