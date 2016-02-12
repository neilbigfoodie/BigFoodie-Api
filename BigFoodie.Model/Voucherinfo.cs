namespace BigFoodie.Model
{
    public class Voucherinfo
    {
        public int Voucherid { get; set; } // voucherid (Primary key)

        ///<summary>
        /// 优惠券代码
        ///</summary>
        public string Vouchercode { get; set; } // vouchercode

        ///<summary>
        /// 生效日期
        ///</summary>
        public System.DateTime? Fromdt { get; set; } // fromdt

        ///<summary>
        /// 失效日期
        ///</summary>
        public System.DateTime? Todt { get; set; } // todt

        ///<summary>
        /// 优惠方式(1:按比例优惠 2:按固定金额优惠)
        ///</summary>
        public string Discountopt { get; set; } // discountopt

        ///<summary>
        /// 优惠值
        ///</summary>
        public decimal? Discountamt { get; set; } // discountamt

        ///<summary>
        /// 起始金额
        ///</summary>
        public decimal? Basicamt { get; set; } // basicamt

        ///<summary>
        /// 有效区域
        ///</summary>
        public string Areacode { get; set; } // areacode

        ///<summary>
        /// 销售人员名字
        ///</summary>
        public string Salesname { get; set; } // salesname

        ///<summary>
        /// 哪个用户可用,为0表示不限定用户
        ///</summary>
        public int? Userid { get; set; } // userid

        ///<summary>
        /// 指定餐馆可用0表示，不限餐馆
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 这个voucher的可用次数
        ///</summary>
        public int? Vouchercount { get; set; } // vouchercount

        ///<summary>
        /// 每个用户可用此voucher次数
        ///</summary>
        public int? Usesperuser { get; set; } // usesperuser

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 创建人
        ///</summary>
        public string Createuser { get; set; } // createuser

        ///<summary>
        /// 关于此优惠券的说明
        ///</summary>
        public string Comment { get; set; } // comment

        ///<summary>
        /// 此记录是否被删除0-未删 1-己删除
        ///</summary>
        public string Isdelete { get; set; } // isdelete

        ///<summary>
        /// 是否己使用。0未使用1己使用
        ///</summary>
        public string Isused { get; set; } // isused
        public decimal? Creditback { get; set; } // creditback

        public Voucherinfo()
        {
            Discountopt = "2";
            Isdelete = "0";
        }
    }
}