namespace BigFoodie.Model
{
    public class Ordercz
    {
        public int Czid { get; set; } // czid (Primary key)
        public System.DateTime Czdt { get; set; } // czdt
        public string Orderid { get; set; } // orderid
        public string Comments { get; set; } // comments
        public decimal? Amt { get; set; } // amt
        public string Operateid { get; set; } // operateid
    }
}