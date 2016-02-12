namespace BigFoodie.Model
{
    public class ShopJzDetail
    {
        public int Id { get; set; } // id (Primary key)
        public int Jzid { get; set; } // jzid
        public int Shopid { get; set; } // shopid
        public string Invoiceid { get; set; } // invoiceid
        public System.DateTime? Frdt { get; set; } // frdt
        public System.DateTime? Todt { get; set; } // todt
        public System.DateTime? Creatdt { get; set; } // creatdt
        public decimal? Amt1 { get; set; } // amt1
        public int? Quan1 { get; set; } // quan1
        public decimal? Web1 { get; set; } // web1
        public decimal? Shop1 { get; set; } // shop1
        public decimal? Amt2 { get; set; } // amt2
        public int? Quan2 { get; set; } // quan2
        public decimal? Web2 { get; set; } // web2
        public decimal? Shop2 { get; set; } // shop2
        public decimal? Amt3 { get; set; } // amt3
        public int? Quan3 { get; set; } // quan3
        public decimal? Web3 { get; set; } // web3
        public decimal? Shop3 { get; set; } // shop3
        public decimal? Webactualget { get; set; } // webactualget
        public decimal? Shopactualget { get; set; } // shopactualget
        public decimal? Num1 { get; set; } // num1
        public decimal? Num2 { get; set; } // num2
        public string Str1 { get; set; } // str1
        public string Isnew { get; set; } // isnew
        public string Ishx { get; set; } // ishx
        public decimal? Amt1C { get; set; } // amt1c

        public ShopJzDetail()
        {
            Isnew = "Y";
            Ishx = "N";
        }
    }
}