﻿using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobPoolMods
    {
        public short Poolid { get; set; }
        public short Modid { get; set; }
        public short Value { get; set; }
        public byte IsMobMod { get; set; }
    }
}
