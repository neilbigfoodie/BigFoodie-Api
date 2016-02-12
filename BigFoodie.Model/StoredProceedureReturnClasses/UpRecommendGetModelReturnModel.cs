namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class UpRecommendGetModelReturnModel
    {
        public System.Int32 recID { get; set; }
        public System.Int32? recUid { get; set; }
        public System.String recName { get; set; }
        public System.String shopname { get; set; }
        public System.String townname { get; set; }
        public System.String addr { get; set; }
        public System.String tel { get; set; }
        public System.String ishandled { get; set; }
        public System.String status { get; set; }
        public System.DateTime? recDate { get; set; }
    }
}