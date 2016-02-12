namespace BigFoodie.Model
{
    public class Orderitem
    {
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 主订单号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 主菜的ID
        ///</summary>
        public int Mid { get; set; } // mid

        ///<summary>
        /// 配菜/定制菜的ID。如果mid=submenuid,则表示为主餐名
        ///</summary>
        public int Submenuid { get; set; } // submenuid

        ///<summary>
        /// 菜内部编码
        ///</summary>
        public string Menucode { get; set; } // menucode

        ///<summary>
        /// 主菜单名（主语言，英语）
        ///</summary>
        public string MenuName { get; set; } // menuName

        ///<summary>
        /// 主菜单名（第二语言）
        ///</summary>
        public string MenuName2 { get; set; } // menuName2

        ///<summary>
        /// 份数
        ///</summary>
        public int? Amount { get; set; } // amount

        ///<summary>
        /// 原价
        ///</summary>
        public decimal? Price1 { get; set; } // price1

        ///<summary>
        /// 折扣后的最终价
        ///</summary>
        public decimal? Discountprice { get; set; } // discountprice

        ///<summary>
        /// 此项菜实际支付总价格=amount * discountprice
        ///</summary>
        public decimal? Totalprice { get; set; } // totalprice

        ///<summary>
        /// 菜单的图片地址
        ///</summary>
        public string Menulogo { get; set; } // menulogo

        ///<summary>
        /// =menu.menutype.此餐的类型:1-主餐;2-可定制餐(将读取submenu表);3-套餐(将读取套餐表).m-表示此项为主食;f-此项为配料。还可以扩展....
        ///</summary>
        public string Menutype { get; set; } // menutype

        ///<summary>
        /// 定制餐的多与缺少项
        ///</summary>
        public string MenuNameE { get; set; } // menuNameE

        ///<summary>
        /// 定制餐的多与缺少项中文名, 比如加什么，免什么
        ///</summary>
        public string MenuName2E { get; set; } // menuName2E
    }
}