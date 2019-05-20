using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharStats
    {
        public int Charid { get; set; }
        public short Hp { get; set; }
        public short Mp { get; set; }
        public int Nameflags { get; set; }
        public byte Mhflag { get; set; }
        public byte Mjob { get; set; }
        public byte Sjob { get; set; }
        public int Death { get; set; }
        public int _2h { get; set; }
        public short Title { get; set; }
        public byte[] BazaarMessage { get; set; }
        public byte Zoning { get; set; }
        public byte Mlvl { get; set; }
        public byte Slvl { get; set; }
        public short PetId { get; set; }
        public short PetType { get; set; }
        public short PetHp { get; set; }
        public short PetMp { get; set; }
    }
}
