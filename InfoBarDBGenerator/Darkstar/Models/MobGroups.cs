using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobGroups
    {
        public int Groupid { get; set; }
        public int Poolid { get; set; }
        public short Zoneid { get; set; }
        public int Respawntime { get; set; }
        public byte Spawntype { get; set; }
        public int Dropid { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public byte Allegiance { get; set; }
    }
}
