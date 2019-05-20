using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.InfoBar.Models
{
    public partial class Monster
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Job { get; set; }
        public string Zone { get; set; }
        public bool IsAggressive { get; set; }
        public bool IsLinking { get; set; }
        public bool IsNm { get; set; }
        public bool IsFishing { get; set; }
        public long? LevelMin { get; set; }
        public long? LevelMax { get; set; }
        public bool DetectsSight { get; set; }
        public bool DetectsSound { get; set; }
        public bool DetectsMagic { get; set; }
        public bool DetectsLowhp { get; set; }
        public bool DetectsHealing { get; set; }
        public bool DetectsTruesight { get; set; }
        public bool DetectsTruesound { get; set; }
        public bool TracksScent { get; set; }
        public string Weaknesses { get; set; }
        public string Resistances { get; set; }
        public string Immunities { get; set; }
        public string Drops { get; set; }
        public string Stolen { get; set; }
        public long? SpawnCount { get; set; }
        public string SpawnTime { get; set; }
        public string SomepageId { get; set; }
        public string AtlasId { get; set; }
        public string FfxiclopediaId { get; set; }
        public string AllakhazamId { get; set; }
    }
}
