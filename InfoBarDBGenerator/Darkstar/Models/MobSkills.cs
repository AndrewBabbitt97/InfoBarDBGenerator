using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class MobSkills
    {
        public short MobSkillId { get; set; }
        public short MobAnimId { get; set; }
        public string MobSkillName { get; set; }
        public byte MobSkillAoe { get; set; }
        public float MobSkillDistance { get; set; }
        public short MobAnimTime { get; set; }
        public short MobPrepareTime { get; set; }
        public short MobValidTargets { get; set; }
        public byte MobSkillFlag { get; set; }
        public short MobSkillParam { get; set; }
        public byte Knockback { get; set; }
        public byte PrimarySc { get; set; }
        public byte SecondarySc { get; set; }
        public byte TertiarySc { get; set; }
    }
}
