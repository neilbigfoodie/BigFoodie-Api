namespace BigFoodie.Model
{
    public class Cashreturn
    {
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 用户ID
        ///</summary>
        public int? Uid { get; set; } // uid

        ///<summary>
        /// 现金详细表ID=membercash.cashid
        ///</summary>
        public int? Cashid { get; set; } // cashid

        ///<summary>
        /// 提取现金金额
        ///</summary>
        public decimal? Amount { get; set; } // amount

        ///<summary>
        /// 现金提取时间
        ///</summary>
        public System.DateTime? Atime { get; set; } // atime

        ///<summary>
        /// 提取款款卡的详细信息ID=creditcard.cardid
        ///</summary>
        public int? Cardid { get; set; } // cardid

        ///<summary>
        /// 卡提取状态。0，处理中;1.己完成2.提取失败。
        ///</summary>
        public string Status { get; set; } // status

        ///<summary>
        /// 备注
        ///</summary>
        public string Comment { get; set; } // comment
    }
}