using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharInventory
    {
        public int Charid { get; set; }
        public byte Location { get; set; }
        public byte Slot { get; set; }
        public short ItemId { get; set; }
        public int Quantity { get; set; }
        public int Bazaar { get; set; }
        public string Signature { get; set; }
        public byte[] Extra { get; set; }
    }
}
