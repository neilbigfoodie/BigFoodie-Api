namespace BigFoodie.Model
{
    public class Adv
    {
        public int Advid { get; set; } // advid (Primary key)
        public string Pc { get; set; } // pc
        public string Townname { get; set; } // townname
        public int? Shopid { get; set; } // shopid
        public string Shoploginname { get; set; } // shoploginname
        public System.DateTime? Starttime { get; set; } // starttime
        public System.DateTime? Endtime { get; set; } // endtime
        public string Urllink { get; set; } // urllink
        public string AdvPic { get; set; } // advPic
        public int? Indexno { get; set; } // indexno
        public int? Clicknum { get; set; } // clicknum
        public System.DateTime? Recdate { get; set; } // recdate
        public string Advposition { get; set; } // advposition
    }
}