using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class GuildShops
    {
        public short Guildid { get; set; }
        public short Itemid { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public short MaxQuantity { get; set; }
        public short DailyIncrease { get; set; }
        public short InitialQuantity { get; set; }
    }
}
