using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AuditGm
    {
        public DateTime DateTime { get; set; }
        public string GmName { get; set; }
        public string Command { get; set; }
        public string FullString { get; set; }
    }
}
