using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Abilities
    {
        public short AbilityId { get; set; }
        public string Name { get; set; }
        public byte Job { get; set; }
        public byte Level { get; set; }
        public short ValidTarget { get; set; }
        public short RecastTime { get; set; }
        public short RecastId { get; set; }
        public short Message1 { get; set; }
        public short Message2 { get; set; }
        public short Animation { get; set; }
        public short AnimationTime { get; set; }
        public short CastTime { get; set; }
        public byte ActionType { get; set; }
        public float Range { get; set; }
        public byte IsAoe { get; set; }
        public short Ce { get; set; }
        public short Ve { get; set; }
        public short MeritModId { get; set; }
        public short AddType { get; set; }
        public string ContentTag { get; set; }
    }
}
