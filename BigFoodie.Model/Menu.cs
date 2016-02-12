namespace BigFoodie.Model
{
    public class Menu
    {

        ///<summary>
        /// 表主键
        ///</summary>
        public int Mid { get; set; } // mid (Primary key)

        ///<summary>
        /// 商家ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 此菜单所属的类别
        ///</summary>
        public string MenuCat { get; set; } // menuCat

        ///<summary>
        /// 菜单名称（英文）
        ///</summary>
        public string MenuName { get; set; } // menuName

        ///<summary>
        /// 菜单名称（第二语言）
        ///</summary>
        public string MenuName2 { get; set; } // menuName2

        ///<summary>
        /// 菜单详细描述(主语言：英语)
        ///</summary>
        public string MenuDesc { get; set; } // menuDesc

        ///<summary>
        /// 菜单详细描述(第二语言)
        ///</summary>
        public string MenuDesc2 { get; set; } // menuDesc2

        ///<summary>
        /// 原价
        ///</summary>
        public decimal? Price1 { get; set; } // price1

        ///<summary>
        /// 折扣价
        ///</summary>
        public decimal? Price2 { get; set; } // price2

        ///<summary>
        /// 本菜被评的星级(备用)
        ///</summary>
        public decimal? Star { get; set; } // star

        ///<summary>
        /// 此餐的类型:1-普通餐;2-套餐(将读取套餐表)
        ///</summary>
        public string Menutype { get; set; } // menutype

        ///<summary>
        /// 菜的图片地址
        ///</summary>
        public string Menulogo { get; set; } // menulogo

        ///<summary>
        /// 折扣计价方式.1。按本菜单固定方式。即price2生效;2.按店的统一折扣价。3.按本菜单的特定时间段的折扣方式(即去查找menuPrice表).缺省值为1.按本菜单方式.
        ///</summary>
        public string Discountway { get; set; } // discountway

        ///<summary>
        /// 菜单编号，由餐馆管理员自行设置
        ///</summary>
        public string Menucode { get; set; } // menucode

        ///<summary>
        /// 服务时段。1- 午餐与晚餐 ;2-午餐only;3-晚餐only
        ///</summary>
        public string ServicePeriod { get; set; } // servicePeriod

        ///<summary>
        /// 此主菜类显示的时间，指周一，周二，到周日，可多选。多个用,号隔开.0,1,2,3,..6
        ///</summary>
        public string Displayweekday { get; set; } // displayweekday

        ///<summary>
        /// 是否显示主食。Y－有，N－不
        ///</summary>
        public string HasSideOrder { get; set; } // hasSideOrder

        ///<summary>
        /// 是否有配料。Y－是。则读取标准配料值plcollection. N。否，不显示配料
        ///</summary>
        public string HasPl { get; set; } // hasPL

        ///<summary>
        /// 标准配料.or 套餐内含的ID
        ///</summary>
        public string Standardpl { get; set; } // standardpl

        ///<summary>
        /// 菜单创建时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // CreateDT

        ///<summary>
        /// 菜单修改时间
        ///</summary>
        public System.DateTime? UpdateDt { get; set; } // UpdateDT

        ///<summary>
        /// 餐特点，1-辣，2-素餐，3-含Nuts,可多选
        ///</summary>
        public string Flag { get; set; } // flag

        ///<summary>
        /// 菜显示顺序号，由餐馆管理员指定
        ///</summary>
        public decimal? Indexnum { get; set; } // indexnum

        ///<summary>
        /// 套餐组成数量
        ///</summary>
        public int? Mealamt { get; set; } // mealamt
        public string Menuoptioncat { get; set; } // menuoptioncat

        public Menu()
        {
            Menutype = "0";
            Discountway = "1";
        }
    }
}