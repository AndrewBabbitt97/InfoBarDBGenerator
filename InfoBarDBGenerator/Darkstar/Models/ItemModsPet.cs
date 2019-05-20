using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemModsPet
    {
        public short ItemId { get; set; }
        public short ModId { get; set; }
        public short Value { get; set; }
        public byte PetType { get; set; }
    }
}
