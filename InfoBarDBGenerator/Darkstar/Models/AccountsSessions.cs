using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AccountsSessions
    {
        public int Accid { get; set; }
        public int Charid { get; set; }
        public short Targid { get; set; }
        public int Linkshellid1 { get; set; }
        public short Linkshellrank1 { get; set; }
        public int Linkshellid2 { get; set; }
        public short Linkshellrank2 { get; set; }
        public byte[] SessionKey { get; set; }
        public int ServerAddr { get; set; }
        public short ServerPort { get; set; }
        public int ClientAddr { get; set; }
        public short ClientPort { get; set; }
        public byte VersionMismatch { get; set; }

        public virtual AccountsParties AccountsParties { get; set; }
    }
}
