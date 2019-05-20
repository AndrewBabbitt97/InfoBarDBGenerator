using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AbilitiesCharges
    {
        public short RecastId { get; set; }
        public byte Job { get; set; }
        public byte Level { get; set; }
        public byte MaxCharges { get; set; }
        public short ChargeTime { get; set; }
        public short MeritModId { get; set; }
    }
}
