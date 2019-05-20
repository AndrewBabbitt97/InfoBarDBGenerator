using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class JobPoints
    {
        public short JobPointid { get; set; }
        public string Name { get; set; }
        public byte Upgrade { get; set; }
        public int Jobs { get; set; }
    }
}
