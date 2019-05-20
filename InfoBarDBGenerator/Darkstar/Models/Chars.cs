using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Chars
    {
        public int Charid { get; set; }
        public int Accid { get; set; }
        public string Charname { get; set; }
        public byte Nation { get; set; }
        public short PosZone { get; set; }
        public short PosPrevzone { get; set; }
        public byte PosRot { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public int Moghouse { get; set; }
        public short Boundary { get; set; }
        public byte HomeZone { get; set; }
        public byte HomeRot { get; set; }
        public float HomeX { get; set; }
        public float HomeY { get; set; }
        public float HomeZ { get; set; }
        public byte[] Missions { get; set; }
        public byte[] Assault { get; set; }
        public byte[] Campaign { get; set; }
        public byte[] Quests { get; set; }
        public byte[] Keyitems { get; set; }
        public byte[] SetBlueSpells { get; set; }
        public byte[] Abilities { get; set; }
        public byte[] Weaponskills { get; set; }
        public byte[] Titles { get; set; }
        public byte[] Zones { get; set; }
        public int Playtime { get; set; }
        public byte[] UnlockedWeapons { get; set; }
        public short Gmlevel { get; set; }
        public short Mentor { get; set; }
        public byte CampaignAllegiance { get; set; }
        public byte Isstylelocked { get; set; }
        public int Nnameflags { get; set; }
        public short Moghancement { get; set; }
    }
}
