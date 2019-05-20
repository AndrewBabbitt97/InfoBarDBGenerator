using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AccountIpRecord
    {
        public DateTime LoginTime { get; set; }
        public int Accid { get; set; }
        public int Charid { get; set; }
        public string ClientIp { get; set; }
    }
}
