using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Linkshells
    {
        public int Linkshellid { get; set; }
        public string Name { get; set; }
        public short Color { get; set; }
        public string Poster { get; set; }
        public byte[] Message { get; set; }
        public int Messagetime { get; set; }
        public byte Postrights { get; set; }
    }
}
