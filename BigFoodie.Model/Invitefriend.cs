namespace BigFoodie.Model
{
    public class Invitefriend
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 发起邀请者的用户ID
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 被邀请人邮件地址
        ///</summary>
        public string Iemail { get; set; } // iemail

        ///<summary>
        /// 被邀请人姓名
        ///</summary>
        public string Iusername { get; set; } // iusername

        ///<summary>
        /// 邀请时间
        ///</summary>
        public System.DateTime? Idatatime { get; set; } // idatatime

        ///<summary>
        /// 邀请码
        ///</summary>
        public string InviteCode { get; set; } // inviteCode

        ///<summary>
        /// 被推荐的用户是否注册,Y是。N否
        ///</summary>
        public string IsReg { get; set; } // isReg

        ///<summary>
        /// 此次推荐是否己获取积分.Y.己获取。N.未获取。缺省值为N
        ///</summary>
        public string IsScore { get; set; } // isScore

        ///<summary>
        /// 此条推荐消息是否完成。Y-完成。N-未完成
        ///</summary>
        public string Isvalid { get; set; } // isvalid

        ///<summary>
        /// 被邀请者的第一个订单号
        ///</summary>
        public string Iorderid { get; set; } // iorderid

        public Invitefriend()
        {
            IsReg = "N";
            IsScore = "N";
        }
    }
}