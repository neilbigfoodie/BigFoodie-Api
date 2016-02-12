namespace BigFoodie.Model
{
    public class Menusideorder
    {
        public int Sideorderid { get; set; } // sideorderid (Primary key)

        ///<summary>
        /// 餐馆id
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 主餐的ID=Menu.mid
        ///</summary>
        public int? Mid { get; set; } // mid

        ///<summary>
        /// 主食英文名
        ///</summary>
        public string Mname { get; set; } // mname

        ///<summary>
        /// 主食中文名
        ///</summary>
        public string Mname2 { get; set; } // mname2
        public decimal? Price1 { get; set; } // price1

        ///<summary>
        /// 价二/优惠价
        ///</summary>
        public decimal? Price2 { get; set; } // price2

        ///<summary>
        /// 优惠时段
        ///</summary>
        public string DiscountPeriod { get; set; } // discountPeriod
    }
}