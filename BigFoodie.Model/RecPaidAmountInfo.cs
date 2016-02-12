namespace BigFoodie.Model
{
    public class RecPaidAmountInfo
    {
        public int Infoid { get; set; } // infoid (Primary key)
        public decimal Basicamt { get; set; } // basicamt
        public System.DateTime? Fromdt { get; set; } // fromdt
        public System.DateTime? Todt { get; set; } // todt
        public decimal? Basicamt2 { get; set; } // basicamt2
    }
}