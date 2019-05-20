using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class WeaponSkills
    {
        public byte Weaponskillid { get; set; }
        public string Name { get; set; }
        public byte[] Jobs { get; set; }
        public byte Type { get; set; }
        public short Skilllevel { get; set; }
        public byte Element { get; set; }
        public byte Animation { get; set; }
        public short AnimationTime { get; set; }
        public byte Range { get; set; }
        public byte Aoe { get; set; }
        public byte PrimarySc { get; set; }
        public byte SecondarySc { get; set; }
        public byte TertiarySc { get; set; }
        public byte MainOnly { get; set; }
        public byte UnlockId { get; set; }
    }
}
