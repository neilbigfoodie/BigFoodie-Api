namespace BigFoodie.Model
{
    public class Commission
    {

        ///<summary>
        /// 店铺=shop.shopid
        ///</summary>
        public int Shopid { get; set; } // shopid (Primary key)

        ///<summary>
        /// 佣金生效开始时间
        ///</summary>
        public System.DateTime? Starttime { get; set; } // starttime

        ///<summary>
        /// 佣金结束开始时间
        ///</summary>
        public System.DateTime? Endtime { get; set; } // endtime

        ///<summary>
        /// 备注信息
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 佣金金额
        ///</summary>
        public decimal Amount { get; set; } // amount

        ///<summary>
        /// 记录修改时间
        ///</summary>
        public System.DateTime? ModifiedDt { get; set; } // modifiedDt
    }
}