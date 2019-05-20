using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class ItemWeapon
    {
        public short ItemId { get; set; }
        public string Name { get; set; }
        public byte Skill { get; set; }
        public byte Subskill { get; set; }
        public short IlvlSkill { get; set; }
        public short IlvlParry { get; set; }
        public short IlvlMacc { get; set; }
        public int DmgType { get; set; }
        public byte Hit { get; set; }
        public int Delay { get; set; }
        public int Dmg { get; set; }
        public short UnlockPoints { get; set; }
    }
}
