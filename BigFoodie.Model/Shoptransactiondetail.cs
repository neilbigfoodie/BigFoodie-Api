namespace BigFoodie.Model
{
    public class Shoptransactiondetail
    {
        public int Tid { get; set; } // tid (Primary key)
        public string Invoiceid { get; set; } // invoiceid
        public string Orderid { get; set; } // orderid
        public System.DateTime? Orderdt { get; set; } // orderdt
        public System.DateTime? Delieverdt { get; set; } // delieverdt
        public decimal? Orderamt { get; set; } // orderamt
        public string Paydesc { get; set; } // paydesc
        public decimal? Comrate { get; set; } // comrate
        public decimal? Webcom { get; set; } // webcom
        public decimal? Shopyd { get; set; } // shopyd
        public string Transtype { get; set; } // transtype
        public decimal? Orderamtc { get; set; } // orderamtc
    }
}