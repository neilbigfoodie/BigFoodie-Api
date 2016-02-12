namespace BigFoodie.Model
{
    public class ShoppingHoliday
    {

        ///<summary>
        /// 表主键，自动增长
        ///</summary>
        public int Holidayid { get; set; } // holidayid (Primary key)

        ///<summary>
        /// 商店ID
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 假日开始时间
        ///</summary>
        public System.DateTime? FromDt { get; set; } // fromDT

        ///<summary>
        /// 假日结束时间
        ///</summary>
        public System.DateTime? ToDt { get; set; } // toDT
    }
}