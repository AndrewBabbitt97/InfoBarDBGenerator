using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ZoneWeather
    {
        public short Zoneid { get; set; }
        public short WeatherDay { get; set; }
        public byte Common { get; set; }
        public byte Normal { get; set; }
        public byte Rare { get; set; }
    }
}
