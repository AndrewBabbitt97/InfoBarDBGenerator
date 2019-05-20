using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class StatusEffects
    {
        public short Id { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }
        public short Type { get; set; }
        public short? NegativeId { get; set; }
        public short Overwrite { get; set; }
        public short? BlockId { get; set; }
        public short RemoveId { get; set; }
        public short Element { get; set; }
        public short MinDuration { get; set; }
    }
}
