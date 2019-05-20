using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ZoneSettings
    {
        public int Zoneid { get; set; }
        public int Zonetype { get; set; }
        public string Zoneip { get; set; }
        public int Zoneport { get; set; }
        public string Name { get; set; }
        public byte MusicDay { get; set; }
        public byte MusicNight { get; set; }
        public byte Battlesolo { get; set; }
        public byte Battlemulti { get; set; }
        public byte Restriction { get; set; }
        public float Tax { get; set; }
        public int Misc { get; set; }
    }
}
