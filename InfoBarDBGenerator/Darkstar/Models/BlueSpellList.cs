using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class BlueSpellList
    {
        public short Spellid { get; set; }
        public short MobSkillId { get; set; }
        public short SetPoints { get; set; }
        public short TraitCategory { get; set; }
        public short TraitCategoryWeight { get; set; }
        public short PrimarySc { get; set; }
        public short SecondarySc { get; set; }
    }
}
