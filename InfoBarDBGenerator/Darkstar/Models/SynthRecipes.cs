using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class SynthRecipes
    {
        public short Id { get; set; }
        public byte Type { get; set; }
        public int KeyItem { get; set; }
        public byte Alchemy { get; set; }
        public byte Bone { get; set; }
        public byte Cloth { get; set; }
        public byte Cook { get; set; }
        public byte Gold { get; set; }
        public byte Leather { get; set; }
        public byte Smith { get; set; }
        public byte Wood { get; set; }
        public short Crystal { get; set; }
        public short Hqcrystal { get; set; }
        public short Ingredient1 { get; set; }
        public short Ingredient2 { get; set; }
        public short Ingredient3 { get; set; }
        public short Ingredient4 { get; set; }
        public short Ingredient5 { get; set; }
        public short Ingredient6 { get; set; }
        public short Ingredient7 { get; set; }
        public short Ingredient8 { get; set; }
        public short Result { get; set; }
        public short ResultHq1 { get; set; }
        public short ResultHq2 { get; set; }
        public short ResultHq3 { get; set; }
        public byte ResultQty { get; set; }
        public byte ResultHq1qty { get; set; }
        public byte ResultHq2qty { get; set; }
        public byte ResultHq3qty { get; set; }
    }
}
