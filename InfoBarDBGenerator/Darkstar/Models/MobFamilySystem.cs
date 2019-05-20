using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobFamilySystem
    {
        public short Familyid { get; set; }
        public string Family { get; set; }
        public byte Systemid { get; set; }
        public string System { get; set; }
        public byte Mobsize { get; set; }
        public byte Speed { get; set; }
        public byte Hp { get; set; }
        public byte Mp { get; set; }
        public short Str { get; set; }
        public short Dex { get; set; }
        public short Vit { get; set; }
        public short Agi { get; set; }
        public short Int { get; set; }
        public short Mnd { get; set; }
        public short Chr { get; set; }
        public short Att { get; set; }
        public short Def { get; set; }
        public short Acc { get; set; }
        public short Eva { get; set; }
        public float Slash { get; set; }
        public float Pierce { get; set; }
        public float H2h { get; set; }
        public float Impact { get; set; }
        public float Fire { get; set; }
        public float Ice { get; set; }
        public float Wind { get; set; }
        public float Earth { get; set; }
        public float Lightning { get; set; }
        public float Water { get; set; }
        public float Light { get; set; }
        public float Dark { get; set; }
        public float Element { get; set; }
        public short Detects { get; set; }
        public byte Charmable { get; set; }
    }
}
