namespace BigFoodie.Model
{
    public class Menubasic
    {

        ///<summary>
        /// 主键。自动增长
        ///</summary>
        public int Basicmenuid { get; set; } // basicmenuid (Primary key)

        ///<summary>
        /// 餐馆ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 菜的主分类.1-配菜类;2-主食;3-..待扩展
        ///</summary>
        public string Menutype1 { get; set; } // menutype1

        ///<summary>
        /// 菜的二级分类，如配菜中的Veg,Meat,Sauce,Cook等
        ///</summary>
        public string Menutype2 { get; set; } // menutype2

        ///<summary>
        /// 菜名
        ///</summary>
        public string Mname { get; set; } // mname

        ///<summary>
        /// 菜名第二种语言
        ///</summary>
        public string Mname2 { get; set; } // mname2

        ///<summary>
        /// 基本价格
        ///</summary>
        public decimal? Price1 { get; set; } // price1

        ///<summary>
        /// 打折后的价格。备用
        ///</summary>
        public decimal? Price2 { get; set; } // price2

        ///<summary>
        /// 菜描述
        ///</summary>
        public string Menudesc { get; set; } // menudesc

        ///<summary>
        /// 菜描述（第二语言）
        ///</summary>
        public string Menudesc2 { get; set; } // menudesc2

        ///<summary>
        /// 菜编码（餐馆内部编码）
        ///</summary>
        public string Menucode { get; set; } // menucode

        ///<summary>
        /// 标记字段，（备用
        ///</summary>
        public string Flag { get; set; } // flag

        ///<summary>
        /// 备用字段
        ///</summary>
        public string Menu001 { get; set; } // menu001

        ///<summary>
        /// 显示顺序号
        ///</summary>
        public decimal? Indexnum { get; set; } // indexnum
    }
}