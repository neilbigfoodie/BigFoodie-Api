namespace BigFoodie.Model
{
    public class VwUserBalanceSummary
    {
        public decimal Balanceid { get; set; } // balanceid
        public int Userid { get; set; } // userid
        public System.DateTime Createdt { get; set; } // createdt
        public string Moneydirection { get; set; } // moneydirection
        public decimal? Amt { get; set; } // amt
        public string Comment { get; set; } // comment
        public decimal Balanceamt { get; set; } // balanceamt
        public int? Shopid { get; set; } // shopid
        public string Orderid { get; set; } // orderid
    }
}