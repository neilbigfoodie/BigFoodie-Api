namespace BigFoodie.Model.StoredProceedureReturnClasses
{
    public class UpShoppingHolidayGetListReturnModel
    {
        public System.Int32 holidayid { get; set; }
        public System.Int32? shopid { get; set; }
        public System.DateTime? fromDT { get; set; }
        public System.DateTime? toDT { get; set; }
    }
}