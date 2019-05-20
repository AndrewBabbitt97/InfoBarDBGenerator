using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BcnmInfo
    {
        public short BcnmId { get; set; }
        public byte ZoneId { get; set; }
        public string Name { get; set; }
        public string FastestName { get; set; }
        public byte FastestPartySize { get; set; }
        public int? FastestTime { get; set; }
        public short TimeLimit { get; set; }
        public short LevelCap { get; set; }
        public short PartySize { get; set; }
        public short LootDropId { get; set; }
        public short Rules { get; set; }
        public byte IsMission { get; set; }
    }
}
