namespace BigFoodie.Model
{
    public class VwGetUserInfo
    {
        public int Uid { get; set; } // uid
        public string Utype { get; set; } // utype
        public string Gender { get; set; } // gender
        public string Realname { get; set; } // realname
        public string Email { get; set; } // email
        public string Pwd { get; set; } // pwd
        public string Pwdquestion { get; set; } // pwdquestion
        public string Pwdanswer { get; set; } // pwdanswer
        public string Birthday { get; set; } // birthday
        public System.DateTime? Lastlogindate { get; set; } // lastlogindate
        public string LastloginIp { get; set; } // lastloginIP
        public string Islocked { get; set; } // islocked
        public int? Score { get; set; } // score
        public string Isblocked { get; set; } // isblocked
        public string Isnoticed { get; set; } // isnoticed
        public System.DateTime? Createdt { get; set; } // createdt
        public string Postcode1 { get; set; } // postcode1
        public string Postcode2 { get; set; } // postcode2
        public string Cityname { get; set; } // cityname
        public int? LoginErrTime { get; set; } // loginErrTime
        public string Mobile { get; set; } // mobile
        public int? Credits { get; set; } // credits
    }
}