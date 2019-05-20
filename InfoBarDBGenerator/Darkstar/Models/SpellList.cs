using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class SpellList
    {
        public short Spellid { get; set; }
        public string Name { get; set; }
        public byte[] Jobs { get; set; }
        public byte Group { get; set; }
        public byte Element { get; set; }
        public short Zonemisc { get; set; }
        public byte ValidTargets { get; set; }
        public byte Skill { get; set; }
        public short MpCost { get; set; }
        public short CastTime { get; set; }
        public int RecastTime { get; set; }
        public short Message { get; set; }
        public short MagicBurstMessage { get; set; }
        public short Animation { get; set; }
        public short AnimationTime { get; set; }
        public byte Aoe { get; set; }
        public short Base { get; set; }
        public float Multiplier { get; set; }
        public int Ce { get; set; }
        public int Ve { get; set; }
        public byte Requirements { get; set; }
        public short SpellRange { get; set; }
        public string ContentTag { get; set; }
    }
}
