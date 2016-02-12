namespace BigFoodie.Model
{
    public class VwGetOrderListForApp
    {
        public string Postcode1 { get; set; } // postcode1
        public string Postcode2 { get; set; } // postcode2
        public string Addr1 { get; set; } // addr1
        public string Addr2 { get; set; } // addr2
        public string Addr3 { get; set; } // addr3
        public System.DateTime? Deliverdt { get; set; } // deliverdt
        public int Shopid { get; set; } // shopid
        public string OrderId { get; set; } // OrderID
        public string Payway { get; set; } // payway
        public string Deliveryway { get; set; } // deliveryway
        public System.DateTime? Pickupdt { get; set; } // pickupdt
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt
        public string IsCancelled { get; set; } // isCancelled
        public string Isnew { get; set; } // isnew
        public string Ispaid { get; set; } // ispaid
        public System.DateTime? OrderCancelledDt { get; set; } // orderCancelledDT
        public string Townname { get; set; } // townname
        public decimal? Totalamount { get; set; } // totalamount
    }
}