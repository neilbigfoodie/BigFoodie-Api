namespace BigFoodie.Model.StoredProceedureReturnModels
{
    public class UpSysMsgGetModelReturnModel
    {
        public System.Int32 msgid { get; set; }
        public System.String msgtitle { get; set; }
        public System.String msgcontent { get; set; }
        public System.DateTime msgdt { get; set; }
        public System.Int32 msgto { get; set; }
        public System.String isread { get; set; }
        public System.DateTime? readdt { get; set; }
    }
}