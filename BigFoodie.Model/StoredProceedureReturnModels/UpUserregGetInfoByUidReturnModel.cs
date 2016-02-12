namespace BigFoodie.Model.StoredProceedureReturnModels
{
    public class UpUserregGetInfoByUidReturnModel
    {
        public System.String utype { get; set; }
        public System.String gender { get; set; }
        public System.String realname { get; set; }
        public System.String email { get; set; }
        public System.String pwd { get; set; }
        public System.String pwdquestion { get; set; }
        public System.String pwdanswer { get; set; }
        public System.String birthday { get; set; }
        public System.DateTime? lastlogindate { get; set; }
        public System.String lastloginIP { get; set; }
        public System.String islocked { get; set; }
        public System.Int32? score { get; set; }
        public System.Int32? credits { get; set; }
        public System.String isblocked { get; set; }
        public System.String isnoticed { get; set; }
        public System.DateTime? createdt { get; set; }
        public System.Int32? loginErrTime { get; set; }
        public System.Int32 uid { get; set; }
        public System.String houseno { get; set; }
        public System.String addr1 { get; set; }
        public System.String postcode1 { get; set; }
        public System.String postcode2 { get; set; }
    }
}