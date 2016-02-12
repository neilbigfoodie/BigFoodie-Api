namespace BigFoodie.Model
{
    public class ShopdeliveryCost
    {

        ///<summary>
        /// 表主键，自动增长
        ///</summary>
        public int Costid { get; set; } // costid (Primary key)

        ///<summary>
        /// 餐馆ID,=shop.shopid
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 配送费用类型. 0.非固定价格(按距离计算).;1-固定价格(按邮編区域指定费用)
        ///</summary>
        public string Costtype { get; set; } // costtype

        ///<summary>
        /// 基本计价距离
        ///</summary>
        public int? BasicDistance { get; set; } // basicDistance

        ///<summary>
        /// 基本距离的的计价价格，
        ///</summary>
        public decimal? BasicPrice { get; set; } // basicPrice

        ///<summary>
        /// 超过基本距离每*miles计价
        ///</summary>
        public int? UnitDistance { get; set; } // unitDistance

        ///<summary>
        /// 超过基本距离,按指令的单价收费
        ///</summary>
        public decimal? UnitRate { get; set; } // unitRate

        ///<summary>
        /// Y/N-是否为优惠送餐。缺省为N
        ///</summary>
        public string IsDiscount { get; set; } // isDiscount

        ///<summary>
        /// 优惠的送餐距离
        ///</summary>
        public int? BasicDistance2 { get; set; } // basicDistance2

        ///<summary>
        /// 优惠送餐的最小订单额
        ///</summary>
        public decimal? MinOrderAmount { get; set; } // minOrderAmount

        ///<summary>
        /// 优惠金额
        ///</summary>
        public decimal? FreeAmount { get; set; } // freeAmount

        public ShopdeliveryCost()
        {
            IsDiscount = "N";
        }
    }
}