using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AccountsParties
    {
        public int Charid { get; set; }
        public int Partyid { get; set; }
        public short Partyflag { get; set; }
        public int Allianceid { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        public virtual AccountsSessions Char { get; set; }
    }
}
