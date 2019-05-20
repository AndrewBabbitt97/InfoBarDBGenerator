using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class Accounts
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public DateTime Timecreate { get; set; }
        public DateTimeOffset Timelastmodify { get; set; }
        public byte ContentIds { get; set; }
        public short Expansions { get; set; }
        public byte Features { get; set; }
        public byte Status { get; set; }
        public byte Priv { get; set; }
    }
}
