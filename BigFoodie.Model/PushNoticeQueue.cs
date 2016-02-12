namespace BigFoodie.Model
{
    public class PushNoticeQueue
    {
        public int Pushid { get; set; } // pushid (Primary key)

        ///<summary>
        /// 订单号（针对订单的推送，否则为空值）
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 消息内容（包含推送时需要的全部内容）
        ///</summary>
        public string Payload { get; set; } // payload

        ///<summary>
        /// 推送总次数.默认为0
        ///</summary>
        public int? Pushcount { get; set; } // pushcount

        ///<summary>
        /// 上次推送时间
        ///</summary>
        public System.DateTime? Lastpushdt { get; set; } // lastpushdt

        ///<summary>
        /// 推送的目标设备ID
        ///</summary>
        public string Devicetoken { get; set; } // devicetoken

        ///<summary>
        /// 推送的目标channels
        ///</summary>
        public string Channels { get; set; } // channels

        ///<summary>
        /// 推送优先级
        ///</summary>
        public int? Priority { get; set; } // Priority

        ///<summary>
        /// 记录最后一次出错的错误信息，便于查找系统问题
        ///</summary>
        public string LastError { get; set; } // LastError

        ///<summary>
        /// 推送信息类型，扩展用.0-餐馆接单信息
        ///</summary>
        public string Noticetype { get; set; } // noticetype
    }
}