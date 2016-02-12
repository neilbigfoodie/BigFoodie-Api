namespace BigFoodie.Model
{
    public class VwSysMsg
    {
        public int Msgto { get; set; } // msgto
        public int Msgid { get; set; } // msgid
        public string Msgtitle { get; set; } // msgtitle
        public System.DateTime Msgdt { get; set; } // msgdt
        public string Msgcontent { get; set; } // msgcontent
        public string Isread { get; set; } // isread
        public string Isdelete { get; set; } // isdelete
        public System.DateTime? Readdt { get; set; } // readdt
        public string Email { get; set; } // email
    }
}