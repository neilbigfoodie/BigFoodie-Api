namespace BigFoodie.Model
{
    public class ShopJz
    {
        public int Jzid { get; set; } // jzid (Primary key)
        public System.DateTime? Createdt { get; set; } // createdt
        public System.DateTime? Jzstartdt { get; set; } // jzstartdt
        public System.DateTime? Jzenddt { get; set; } // jzenddt
        public int? Shopnum { get; set; } // shopnum
        public decimal? Totalamt { get; set; } // totalamt
        public decimal? Orderamt { get; set; } // orderamt
        public decimal? Actualamt { get; set; } // actualamt
        public int? Ordernumber { get; set; } // ordernumber
        public decimal? Webamt { get; set; } // webamt
        public decimal? Webactual { get; set; } // webactual
        public decimal? Shopamt { get; set; } // shopamt
        public decimal? Paytoshop { get; set; } // paytoshop
        public string Str1 { get; set; } // str1
        public string Str2 { get; set; } // str2
        public int? Bkint1 { get; set; } // bkint1
        public decimal? Bknum1 { get; set; } // bknum1
        public string Createuser { get; set; } // createuser

        public ShopJz()
        {
            Bkint1 = 0;
            Bknum1 = 0m;
        }
    }
}