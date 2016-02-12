namespace BigFoodie.Model
{
    public class Shopdiscount
    {
        public int Shopid { get; set; } // shopid (Primary key)

        ///<summary>
        /// 餐馆公告信息，可以餐厅管理员自行及时维护打折及其它信息
        ///</summary>
        public string Board { get; set; } // board

        ///<summary>
        /// 优惠/打折方式 0-全埸打折 1-按订单优惠 2-无整体打折
        ///</summary>
        public string Discountway { get; set; } // discountway

        ///<summary>
        /// 当订单总金额达多少时，才打扣
        ///</summary>
        public decimal? Minorderamt { get; set; } // minorderamt

        ///<summary>
        /// 打折率.此处存整数，计算时为百分比.
        ///</summary>
        public int? Discountrate { get; set; } // discountrate
    }
}