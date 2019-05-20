using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AutomatonSpells
    {
        public short Spellid { get; set; }
        public short Skilllevel { get; set; }
        public byte Heads { get; set; }
        public short Enfeeble { get; set; }
        public short Immunity { get; set; }
        public int Removes { get; set; }
    }
}
