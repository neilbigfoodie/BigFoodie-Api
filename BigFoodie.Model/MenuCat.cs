namespace BigFoodie.Model
{
    public class MenuCat
    {

        ///<summary>
        /// 菜单类别id
        ///</summary>
        public int Catid { get; set; } // catid (Primary key)

        ///<summary>
        /// 所属餐馆ID=shop.shopid
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 菜单类别名(主语言：英语)
        ///</summary>
        public string CatName { get; set; } // catName

        ///<summary>
        /// 菜单类别名(第二语言)
        ///</summary>
        public string CatName2 { get; set; } // catName2

        ///<summary>
        /// 菜单类别描述（主语言：英语）
        ///</summary>
        public string Description { get; set; } // description

        ///<summary>
        /// 菜单类别描述（第二语言）
        ///</summary>
        public string Description2 { get; set; } // description2

        ///<summary>
        /// 服务时段。1- 午餐与晚餐 ;2-午餐only;3-晚餐only
        ///</summary>
        public string ServicePeriod { get; set; } // servicePeriod

        ///<summary>
        /// 此主菜类显示的时间，指周一，周二，到周日，可多选。多个用,号隔开.0,1,2,3,..6
        ///</summary>
        public string Displayweekday { get; set; } // displayweekday

        ///<summary>
        /// 菜单分类的配菜类库。待定，也许存配菜类库的ID号，也许存一个标识位
        ///</summary>
        public string Pcsetting { get; set; } // pcsetting

        ///<summary>
        /// 此分类创建的时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // createDT

        ///<summary>
        /// 此分类修改的时间
        ///</summary>
        public System.DateTime? ModifiedDt { get; set; } // modifiedDT

        ///<summary>
        /// 类别的顺序号，排序用
        ///</summary>
        public decimal? Indexnum { get; set; } // indexnum

        ///<summary>
        /// 餐类别的图片地址
        ///</summary>
        public string Logostr { get; set; } // logostr
    }
}