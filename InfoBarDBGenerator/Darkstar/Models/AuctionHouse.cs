using System;
using System.Collections.Generic;

namespace InfoBarDBGenerator.Darkstar.Models
{
    public partial class AuctionHouse
    {
        public int Id { get; set; }
        public short Itemid { get; set; }
        public byte Stack { get; set; }
        public int Seller { get; set; }
        public string SellerName { get; set; }
        public int Date { get; set; }
        public int Price { get; set; }
        public string BuyerName { get; set; }
        public int Sale { get; set; }
        public int SellDate { get; set; }
    }
}
