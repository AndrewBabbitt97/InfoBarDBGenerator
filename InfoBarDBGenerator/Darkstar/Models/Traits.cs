using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Traits
    {
        public byte Traitid { get; set; }
        public string Name { get; set; }
        public byte Job { get; set; }
        public byte Level { get; set; }
        public byte Rank { get; set; }
        public short Modifier { get; set; }
        public short Value { get; set; }
        public string ContentTag { get; set; }
        public short Meritid { get; set; }
    }
}
