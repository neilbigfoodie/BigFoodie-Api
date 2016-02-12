namespace BigFoodie.Model
{
    public class VwGetAppRestInfo
    {
        public int Shopid { get; set; } // shopid
        public System.DateTime Createdt { get; set; } // createdt
        public string Isaccepted { get; set; } // isaccepted
        public System.DateTime? Acceptdt { get; set; } // acceptdt
        public string Acceptuserid { get; set; } // acceptuserid
        public int? Recuserid { get; set; } // recuserid
        public decimal? Recamt { get; set; } // recamt
        public string Ispaidrec { get; set; } // ispaidrec
        public System.DateTime? Recpaiddt { get; set; } // recpaiddt
        public string Operatename { get; set; } // operatename
        public string Shopstatus { get; set; } // shopstatus
        public string Sname { get; set; } // sname
        public string Cityname { get; set; } // cityname
        public string Addr1 { get; set; } // addr1
        public string Addr2 { get; set; } // addr2
        public string Postcode1 { get; set; } // postcode1
        public string Postcode2 { get; set; } // postcode2
        public string Contactname { get; set; } // contactname
        public string ContactTel { get; set; } // contactTel
    }
}