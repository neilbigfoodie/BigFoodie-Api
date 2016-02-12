namespace BigFoodie.Model
{
    public class UserCreditInfo
    {

        ///<summary>
        /// 流水号，自动增长。主键
        ///</summary>
        public decimal Balanceid { get; set; } // balanceid (Primary key)

        ///<summary>
        /// 用户ID
        ///</summary>
        public int Userid { get; set; } // userid

        ///<summary>
        /// 发生时间
        ///</summary>
        public System.DateTime Createdt { get; set; } // createdt

        ///<summary>
        /// 资金进出方向
        ///</summary>
        public string Moneydirection { get; set; } // moneydirection

        ///<summary>
        /// 发生金额
        ///</summary>
        public decimal? Amt { get; set; } // amt

        ///<summary>
        /// 备注信息
        ///</summary>
        public string Comment { get; set; } // comment

        ///<summary>
        /// 本次操作后的余额
        ///</summary>
        public decimal Balanceamt { get; set; } // balanceamt

        ///<summary>
        /// 相关联的餐馆ID
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 相关联的订单ID
        ///</summary>
        public string Orderid { get; set; } // orderid
    }
}