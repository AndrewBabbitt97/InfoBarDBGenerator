using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Transport
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int Transport1 { get; set; }
        public int Door { get; set; }
        public float DockX { get; set; }
        public float DockY { get; set; }
        public float DockZ { get; set; }
        public byte DockRot { get; set; }
        public short Boundary { get; set; }
        public byte AnimArrive { get; set; }
        public byte AnimDepart { get; set; }
        public short TimeOffset { get; set; }
        public short TimeInterval { get; set; }
        public byte TimeAnimArrive { get; set; }
        public short TimeWaiting { get; set; }
        public byte TimeAnimDepart { get; set; }
        public byte Zone { get; set; }
    }
}
