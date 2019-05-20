using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BcnmBattlefield
    {
        public short BcnmId { get; set; }
        public byte? BattlefieldNumber { get; set; }
        public int MonsterId { get; set; }
        public byte Conditions { get; set; }
        public int Trashid { get; set; }
    }
}
