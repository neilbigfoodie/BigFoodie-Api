namespace BigFoodie.Model
{
    public class Submenu
    {

        ///<summary>
        /// 子菜单主键ID
        ///</summary>
        public int Smid { get; set; } // smid (Primary key)

        ///<summary>
        /// 主菜单ID
        ///</summary>
        public int Mid { get; set; } // mid

        ///<summary>
        /// 子菜单名字(主语言：英语)
        ///</summary>
        public string MenuName { get; set; } // menuName

        ///<summary>
        /// 子菜单名字(第二语言)
        ///</summary>
        public string MenuName2 { get; set; } // menuName2

        ///<summary>
        /// 子菜单描述（主语言：英语）
        ///</summary>
        public string MenuDesc { get; set; } // menuDesc

        ///<summary>
        /// 子菜单描述（第二语言）
        ///</summary>
        public string MenuDesc2 { get; set; } // menuDesc2

        ///<summary>
        /// 子菜单项对应的价格
        ///</summary>
        public decimal? Price { get; set; } // price

        ///<summary>
        /// 子菜/配菜对应的分类.直接存放分类名称
        ///</summary>
        public string Submenucat { get; set; } // submenucat
    }
}