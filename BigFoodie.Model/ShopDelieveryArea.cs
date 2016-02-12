namespace BigFoodie.Model
{
    public class ShopDelieveryArea
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Did { get; set; } // did (Primary key)

        ///<summary>
        /// 商店/餐馆ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 配送地区的邮編的第一部分
        ///</summary>
        public string Postcode1 { get; set; } // postcode1
        public decimal? DelieveryCost { get; set; } // delieveryCost

        ///<summary>
        /// 配送信息说明
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 配送地址指定的时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // createDT

        ///<summary>
        /// 标识位，备用
        ///</summary>
        public string Flag1 { get; set; } // flag1

        ///<summary>
        /// 备用字段2
        ///</summary>
        public string Bak001 { get; set; } // bak001

        public ShopDelieveryArea()
        {
            DelieveryCost = 0m;
        }
    }
}