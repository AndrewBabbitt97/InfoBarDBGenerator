using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobPools
    {
        public int Poolid { get; set; }
        public string Name { get; set; }
        public string PacketName { get; set; }
        public short Familyid { get; set; }
        public byte[] Modelid { get; set; }
        public byte MJob { get; set; }
        public byte SJob { get; set; }
        public byte CmbSkill { get; set; }
        public short CmbDelay { get; set; }
        public short CmbDmgMult { get; set; }
        public short Behavior { get; set; }
        public byte Aggro { get; set; }
        public byte TrueDetection { get; set; }
        public byte Links { get; set; }
        public short MobType { get; set; }
        public int Immunity { get; set; }
        public byte NamePrefix { get; set; }
        public int Flag { get; set; }
        public int EntityFlags { get; set; }
        public byte Animationsub { get; set; }
        public byte HasSpellScript { get; set; }
        public short SpellList { get; set; }
        public byte Namevis { get; set; }
        public short Roamflag { get; set; }
        public short SkillListId { get; set; }
    }
}
