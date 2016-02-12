namespace BigFoodie.Model
{
    public class Blocklist
    {

        ///<summary>
        /// 黑名单ID，自动增长
        ///</summary>
        public int Blockid { get; set; } // blockid (Primary key)

        ///<summary>
        /// 邮件地址
        ///</summary>
        public string Email { get; set; } // email

        ///<summary>
        /// 移动电话
        ///</summary>
        public string Mobile { get; set; } // mobile

        ///<summary>
        /// 座机号
        ///</summary>
        public string Landline { get; set; } // landline

        ///<summary>
        /// 订单号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 此订单所在的餐馆ID
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 加入黑名单的时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 加入黑名单的原因
        ///</summary>
        public string Reason { get; set; } // reason

        ///<summary>
        /// 加入人的ID号
        ///</summary>
        public string Createuser { get; set; } // createuser
    }
}