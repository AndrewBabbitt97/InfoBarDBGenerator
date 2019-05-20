using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharUnlocks
    {
        public int Charid { get; set; }
        public int SandoriaSupply { get; set; }
        public int BastokSupply { get; set; }
        public int WindurstSupply { get; set; }
        public int MogLocker { get; set; }
        public byte RunicPortal { get; set; }
        public int Maw { get; set; }
        public int PastSandoriaTp { get; set; }
        public int PastBastokTp { get; set; }
        public int PastWindurstTp { get; set; }
        public byte[] Homepoints { get; set; }
    }
}
