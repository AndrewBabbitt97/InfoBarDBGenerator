using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BcnmTreasureChests
    {
        public short BcnmId { get; set; }
        public byte? BattlefieldNumber { get; set; }
        public int NpcId { get; set; }
        public int Trashid { get; set; }
    }
}
