using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemLatents
    {
        public short ItemId { get; set; }
        public short ModId { get; set; }
        public short Value { get; set; }
        public short LatentId { get; set; }
        public short LatentParam { get; set; }
    }
}
