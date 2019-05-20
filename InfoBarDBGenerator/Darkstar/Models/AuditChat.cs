using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AuditChat
    {
        public int LineId { get; set; }
        public string Speaker { get; set; }
        public string Type { get; set; }
        public string LsName { get; set; }
        public string Recipient { get; set; }
        public byte[] Message { get; set; }
        public DateTime Datetime { get; set; }
    }
}
