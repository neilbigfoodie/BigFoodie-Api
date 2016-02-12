namespace BigFoodie.Model
{
    public class MenuPrice
    {

        ///<summary>
        /// 菜单价格主键ID
        ///</summary>
        public int Pid { get; set; } // pid (Primary key)

        ///<summary>
        /// 主菜单ID=menu.mid
        ///</summary>
        public int Mid { get; set; } // mid

        ///<summary>
        /// 菜单价格
        ///</summary>
        public decimal? Price { get; set; } // price

        ///<summary>
        /// 有效时间段起点时间
        ///</summary>
        public System.DateTime? Dtfrom { get; set; } // dtfrom

        ///<summary>
        /// 有效时间段结束时间
        ///</summary>
        public System.DateTime? Dtto { get; set; } // dtto

        ///<summary>
        /// 时间段的类型：1 每天，2。固定时间段
        ///</summary>
        public string Ptype { get; set; } // ptype

        ///<summary>
        /// 价格的描述。备用
        ///</summary>
        public string Description { get; set; } // description
    }
}