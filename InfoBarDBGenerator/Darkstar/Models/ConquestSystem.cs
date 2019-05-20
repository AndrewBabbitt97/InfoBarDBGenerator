using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ConquestSystem
    {
        public byte RegionId { get; set; }
        public byte RegionControl { get; set; }
        public byte RegionControlPrev { get; set; }
        public int SandoriaInfluence { get; set; }
        public int BastokInfluence { get; set; }
        public int WindurstInfluence { get; set; }
        public int BeastmenInfluence { get; set; }
    }
}
