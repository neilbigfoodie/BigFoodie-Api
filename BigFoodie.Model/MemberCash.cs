namespace BigFoodie.Model
{
    public class MemberCash
    {

        ///<summary>
        /// 表主键，自动增长
        ///</summary>
        public int Cashid { get; set; } // cashid (Primary key)

        ///<summary>
        /// 用户ID
        ///</summary>
        public string Uid { get; set; } // uid

        ///<summary>
        /// 款项金额
        ///</summary>
        public decimal? Amount { get; set; } // amount

        ///<summary>
        /// 款项来源说明
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 发生时间
        ///</summary>
        public System.DateTime? Atime { get; set; } // atime

        ///<summary>
        /// 处理方式。’＋‘表示余款进帐，’－‘表示消费了
        ///</summary>
        public string Action { get; set; } // action

        ///<summary>
        /// 款项处理人
        ///</summary>
        public string Adminuid { get; set; } // adminuid
    }
}