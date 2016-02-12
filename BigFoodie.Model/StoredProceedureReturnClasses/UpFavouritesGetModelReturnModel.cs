namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class UpFavouritesGetModelReturnModel
    {
        public System.Int32 fid { get; set; }
        public System.Int32 uid { get; set; }
        public System.String ftype { get; set; }
        public System.Int32? shopid { get; set; }
        public System.Int32? mid { get; set; }
        public System.DateTime? createDT { get; set; }
        public System.String flag { get; set; }
    }
}