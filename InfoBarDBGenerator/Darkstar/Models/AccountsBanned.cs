using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AccountsBanned
    {
        public int Accid { get; set; }
        public DateTime Timebann { get; set; }
        public DateTime Timeunbann { get; set; }
        public string Banncomment { get; set; }
    }
}
