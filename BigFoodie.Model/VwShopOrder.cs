namespace BigFoodie.Model
{
    public class VwShopOrder
    {
        public int Shopid { get; set; } // shopid
        public string Sname { get; set; } // sname
        public string Addr1 { get; set; } // addr1
        public string Addr2 { get; set; } // addr2
        public string Cityname { get; set; } // cityname
        public string Expr1 { get; set; } // Expr1
        public string Tel1 { get; set; } // tel1
        public int? Count { get; set; } // count
        public decimal? Sum { get; set; } // sum
    }
}