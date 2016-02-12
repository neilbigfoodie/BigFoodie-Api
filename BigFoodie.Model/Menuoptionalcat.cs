namespace BigFoodie.Model
{
    public class Menuoptionalcat
    {
        public decimal Optioncatid { get; set; } // optioncatid (Primary key)
        public int Shopid { get; set; } // shopid (Primary key)
        public string Optionname { get; set; } // optionname
        public string Optionname2 { get; set; } // optionname2
        public string Flag { get; set; } // flag
        public decimal? Indexnum { get; set; } // indexnum
        public string Optiondesc { get; set; } // optiondesc

        public Menuoptionalcat()
        {
            Indexnum = 0m;
        }
    }
}