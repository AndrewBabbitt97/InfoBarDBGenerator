using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Augments
    {
        public short AugmentId { get; set; }
        public short Multiplier { get; set; }
        public short ModId { get; set; }
        public short Value { get; set; }
        public byte IsPet { get; set; }
        public byte PetType { get; set; }
    }
}
