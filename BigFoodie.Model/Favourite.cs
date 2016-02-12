namespace BigFoodie.Model
{
    public class Favourite
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Fid { get; set; } // fid (Primary key)

        ///<summary>
        /// 用户ID，=userReg.uid
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 类型.1:表示收藏餐厅名;2.表示收藏的订单
        ///</summary>
        public string Ftype { get; set; } // ftype

        ///<summary>
        /// 餐馆ID.＝userReg.uid(utype='1')
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 菜单ID.对应菜单表的索引ID号
        ///</summary>
        public int? Mid { get; set; } // mid

        ///<summary>
        /// 加入收藏夹的时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // createDT

        ///<summary>
        /// 备用字段, 订单ID
        ///</summary>
        public string Flag { get; set; } // flag
    }
}