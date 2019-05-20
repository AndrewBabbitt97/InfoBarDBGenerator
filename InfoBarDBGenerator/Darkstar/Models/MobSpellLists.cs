using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobSpellLists
    {
        public string SpellListName { get; set; }
        public short SpellListId { get; set; }
        public short SpellId { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
    }
}
