namespace BigFoodie.Model
{
    public class VwOrdersValid
    {
        public string OrderId { get; set; } // OrderID
        public int Shopid { get; set; } // shopid
        public int Uid { get; set; } // uid
        public string Useremail { get; set; } // useremail
        public int? Amount { get; set; } // amount
        public decimal? Unitprice { get; set; } // unitprice
        public string Payway { get; set; } // payway
        public string Ispaid { get; set; } // ispaid
        public string Ticketnumber { get; set; } // ticketnumber
        public int? Ticketvalue { get; set; } // ticketvalue
        public string Deliveryway { get; set; } // deliveryway
        public System.DateTime? Pickupdt { get; set; } // pickupdt
        public string Comments { get; set; } // comments
        public string Orderstatus { get; set; } // orderstatus
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt
        public System.DateTime? OrderUpdatedt { get; set; } // orderUpdatedt
        public string IsCancelled { get; set; } // isCancelled
        public System.DateTime? OrderCancelledDt { get; set; } // orderCancelledDT
        public string CancelComments { get; set; } // cancelComments
        public decimal? Totalamount { get; set; } // totalamount
        public decimal? Totalprice1 { get; set; } // totalprice1
        public decimal? DiscountRate { get; set; } // discountRate
        public decimal? Afterdiscount { get; set; } // afterdiscount
        public decimal? Deliverycharge { get; set; } // deliverycharge
        public decimal? ServiceCharge { get; set; } // serviceCharge
        public decimal? CreditcardCharge { get; set; } // creditcardCharge
        public decimal? Tips { get; set; } // tips
        public string Isjz { get; set; } // isjz
        public System.DateTime? Jzdt { get; set; } // jzdt
        public decimal? Actualamount { get; set; } // actualamount
        public string UserIp { get; set; } // userIP
        public string Isnew { get; set; } // isnew
        public decimal? Comrate { get; set; } // comrate
    }
}