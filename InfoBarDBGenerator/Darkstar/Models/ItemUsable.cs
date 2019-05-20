using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemUsable
    {
        public short Itemid { get; set; }
        public string Name { get; set; }
        public byte ValidTargets { get; set; }
        public byte Activation { get; set; }
        public short Animation { get; set; }
        public byte AnimationTime { get; set; }
        public byte MaxCharges { get; set; }
        public byte UseDelay { get; set; }
        public int ReuseDelay { get; set; }
        public byte Aoe { get; set; }
    }
}
