namespace BigFoodie.Model
{
    public class MenuCatBasicMenu
    {
        public int Indexid { get; set; } // indexid (Primary key)

        ///<summary>
        /// 菜单类别ID号
        ///</summary>
        public int Catid { get; set; } // catid

        ///<summary>
        /// 餐馆ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 配料主分类1级.1-配料;2-主食
        ///</summary>
        public string Menutype1 { get; set; } // menutype1

        ///<summary>
        /// 配料二级分类
        ///</summary>
        public string Menutype2 { get; set; } // menutype2

        ///<summary>
        /// 配料ID集合，用,号隔开.
        ///</summary>
        public string Basicmenuids { get; set; } // basicmenuids
    }
}