namespace BigFoodie.Model
{
    public class VwValidOrder
    {
        public string OrderId { get; set; } // OrderID
        public string Payway { get; set; } // payway
        public int Shopid { get; set; } // shopid
        public int Uid { get; set; } // uid
        public string Ispaid { get; set; } // ispaid
        public string Deliveryway { get; set; } // deliveryway
        public System.DateTime? Pickupdt { get; set; } // pickupdt
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt
        public string IsCancelled { get; set; } // isCancelled
        public decimal? Totalamount { get; set; } // totalamount
        public decimal? Totalprice1 { get; set; } // totalprice1
        public decimal? Afterdiscount { get; set; } // afterdiscount
        public decimal? Deliverycharge { get; set; } // deliverycharge
        public decimal? CreditcardCharge { get; set; } // creditcardCharge
        public decimal? Tips { get; set; } // tips
        public decimal? Actualamount { get; set; } // actualamount
        public string Isjz { get; set; } // isjz
        public decimal? Comrate { get; set; } // comrate
    }
}