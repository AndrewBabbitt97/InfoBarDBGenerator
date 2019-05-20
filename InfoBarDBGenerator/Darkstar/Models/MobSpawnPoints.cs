using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobSpawnPoints
    {
        public int Mobid { get; set; }
        public string Mobname { get; set; }
        public string PolutilsName { get; set; }
        public int Groupid { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public byte PosRot { get; set; }
    }
}
