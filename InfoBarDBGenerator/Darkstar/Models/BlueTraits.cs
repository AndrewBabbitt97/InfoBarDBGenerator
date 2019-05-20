using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BlueTraits
    {
        public short TraitCategory { get; set; }
        public short TraitPointsNeeded { get; set; }
        public byte Traitid { get; set; }
        public short Modifier { get; set; }
        public short Value { get; set; }
    }
}
