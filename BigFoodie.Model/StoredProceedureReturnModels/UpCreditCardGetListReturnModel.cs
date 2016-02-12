namespace BigFoodie.Model.StoredProceedureReturnModels
{
    public class UpCreditCardGetListReturnModel
    {
        public System.Int32 cardid { get; set; }
        public System.Int32 uid { get; set; }
        public System.String ACCT { get; set; }
        public System.String AcctType { get; set; }
        public System.String Street { get; set; }
        public System.String city { get; set; }
        public System.String state { get; set; }
        public System.String country { get; set; }
        public System.String zip { get; set; }
        public System.Int32? cardIssue { get; set; }
        public System.String cardStart { get; set; }
        public System.String expDate { get; set; }
        public System.String firstName { get; set; }
        public System.String lastName { get; set; }
        public System.String CVV2 { get; set; }
        public System.DateTime? createDT { get; set; }
    }
}