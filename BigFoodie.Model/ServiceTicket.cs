namespace BigFoodie.Model
{
    public class ServiceTicket
    {
        public int Ticketid { get; set; } // ticketid (Primary key)

        ///<summary>
        /// 订单ID
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 客户ID
        ///</summary>
        public int? Userid { get; set; } // userid

        ///<summary>
        /// 餐馆ID
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 电话
        ///</summary>
        public string Tele { get; set; } // tele

        ///<summary>
        /// 邮件地址
        ///</summary>
        public string Email { get; set; } // email

        ///<summary>
        /// 普通咨询;Y-是;N-不是
        ///</summary>
        public string Isnormal { get; set; } // isnormal

        ///<summary>
        /// 是否经理处理.咨询;Y-是;N-不是
        ///</summary>
        public string Ismanager { get; set; } // ismanager

        ///<summary>
        /// 是否紧急;Y-是;N-不是
        ///</summary>
        public string Iscritical { get; set; } // iscritical

        ///<summary>
        /// 客人电话内容
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 处理状态.0-未完成 1-完成
        ///</summary>
        public string Status { get; set; } // status

        ///<summary>
        /// 创建客服记录帐号
        ///</summary>
        public string Createuser { get; set; } // createuser

        ///<summary>
        /// 服务创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 处理时间
        ///</summary>
        public System.DateTime? Updatedt { get; set; } // updatedt

        ///<summary>
        /// 操作客服记录的帐号
        ///</summary>
        public string Modifyuser { get; set; } // modifyuser

        public ServiceTicket()
        {
            Status = "0";
        }
    }
}