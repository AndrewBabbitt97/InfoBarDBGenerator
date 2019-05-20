using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class SkillchainDamageModifiers
    {
        public string ChainLevel { get; set; }
        public string ChainCount { get; set; }
        public int InitialModifier { get; set; }
        public int MagicBurstModifier { get; set; }
    }
}
