namespace BigFoodie.Model
{
    public class VwGetOrderInfo
    {
        public int Shopid { get; set; } // shopid
        public string Sname { get; set; } // sname
        public string OrderId { get; set; } // OrderID
        public string Useremail { get; set; } // useremail
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt
        public string Deliveryway { get; set; } // deliveryway
        public string Sname2 { get; set; } // sname2
        public string Ispaid { get; set; } // ispaid
        public string Payway { get; set; } // payway
        public string Isnew { get; set; } // isnew
        public System.DateTime? Pickupdt { get; set; } // pickupdt
        public int Uid { get; set; } // uid
        public string Orderstatustxt { get; set; } // orderstatustxt
        public string Tel1 { get; set; } // tel1
        public decimal? Totalamount { get; set; } // totalamount
    }
}