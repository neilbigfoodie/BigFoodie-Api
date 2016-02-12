namespace BigFoodie.Model
{
    public class VwGetOrderInfoForAdmin
    {
        public int Shopid { get; set; } // shopid
        public string Sname { get; set; } // sname
        public string Cityname { get; set; } // cityname
        public string OrderId { get; set; } // OrderID
        public string Useremail { get; set; } // useremail
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt
        public string Orderstatus { get; set; } // orderstatus
        public string Deliveryway { get; set; } // deliveryway
        public string Sname2 { get; set; } // sname2
        public string Ispaid { get; set; } // ispaid
        public string Payway { get; set; } // payway
        public string Isnew { get; set; } // isnew
        public System.DateTime? Pickupdt { get; set; } // pickupdt
        public int Uid { get; set; } // uid
        public string Postcode1 { get; set; } // postcode1
        public string Postcode2 { get; set; } // postcode2
        public string Orderstatustxt { get; set; } // orderstatustxt
        public System.DateTime? Isonline { get; set; } // isonline
        public string Acceptorder { get; set; } // acceptorder
        public string Isjz { get; set; } // isjz
        public string IsCancelled { get; set; } // isCancelled
        public decimal? Comrate { get; set; } // comrate
        public decimal? Totalamount { get; set; } // totalamount
    }
}