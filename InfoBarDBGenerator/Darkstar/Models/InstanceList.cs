using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class InstanceList
    {
        public byte Instanceid { get; set; }
        public string InstanceName { get; set; }
        public byte EntranceZone { get; set; }
        public byte TimeLimit { get; set; }
        public float StartX { get; set; }
        public float StartY { get; set; }
        public float StartZ { get; set; }
        public byte StartRot { get; set; }
        public short MusicDay { get; set; }
        public short MusicNight { get; set; }
        public short Battlesolo { get; set; }
        public short Battlemulti { get; set; }
    }
}
