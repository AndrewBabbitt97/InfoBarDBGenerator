using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class GuildItemPoints
    {
        public byte Guildid { get; set; }
        public short Itemid { get; set; }
        public short Rank { get; set; }
        public short Points { get; set; }
        public short MaxPoints { get; set; }
        public byte Pattern { get; set; }
    }
}
