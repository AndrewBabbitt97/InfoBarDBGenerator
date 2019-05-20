using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobDroplist
    {
        public short DropId { get; set; }
        public byte DropType { get; set; }
        public byte GroupId { get; set; }
        public short GroupRate { get; set; }
        public short ItemId { get; set; }
        public short ItemRate { get; set; }
        public int Trashid { get; set; }
    }
}
