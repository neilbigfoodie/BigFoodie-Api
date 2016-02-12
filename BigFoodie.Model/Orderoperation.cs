namespace BigFoodie.Model
{
    public class Orderoperation
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 订单号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 操作描述
        ///</summary>
        public string Actionstr { get; set; } // actionstr

        ///<summary>
        /// 操作时间
        ///</summary>
        public System.DateTime? Actiondt { get; set; } // actiondt

        ///<summary>
        /// 操作人（备用）
        ///</summary>
        public string Actionuser { get; set; } // actionuser
    }
}