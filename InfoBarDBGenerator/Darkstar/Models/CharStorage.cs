﻿using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class CharStorage
    {
        public int Charid { get; set; }
        public byte Inventory { get; set; }
        public byte Safe { get; set; }
        public byte Locker { get; set; }
        public byte Satchel { get; set; }
        public byte Sack { get; set; }
        public byte Case { get; set; }
        public byte Wardrobe { get; set; }
        public byte Wardrobe2 { get; set; }
        public byte Wardrobe3 { get; set; }
        public byte Wardrobe4 { get; set; }
    }
}
