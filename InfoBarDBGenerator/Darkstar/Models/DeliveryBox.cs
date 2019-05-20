using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class DeliveryBox
    {
        public int Charid { get; set; }
        public string Charname { get; set; }
        public byte Box { get; set; }
        public short Slot { get; set; }
        public short Itemid { get; set; }
        public short Itemsubid { get; set; }
        public int Quantity { get; set; }
        public byte[] Extra { get; set; }
        public int Senderid { get; set; }
        public string Sender { get; set; }
        public byte Received { get; set; }
        public byte Sent { get; set; }
    }
}
