using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Zonelines
    {
        public int Zoneline { get; set; }
        public short Fromzone { get; set; }
        public short Tozone { get; set; }
        public float Tox { get; set; }
        public float Toy { get; set; }
        public float Toz { get; set; }
        public byte Rotation { get; set; }
    }
}
