using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class WaterPoints
    {
        public int Waterid { get; set; }
        public short Zoneid { get; set; }
        public byte Type { get; set; }
        public byte Pointid { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
    }
}
