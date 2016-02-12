namespace BigFoodie.Model
{
    public class SysMsg
    {

        ///<summary>
        /// 主键，自动增长键
        ///</summary>
        public int Msgid { get; set; } // msgid (Primary key)

        ///<summary>
        /// 消息主题
        ///</summary>
        public string Msgtitle { get; set; } // msgtitle

        ///<summary>
        /// 消息内容
        ///</summary>
        public string Msgcontent { get; set; } // msgcontent

        ///<summary>
        /// 消息发送时间
        ///</summary>
        public System.DateTime Msgdt { get; set; } // msgdt

        ///<summary>
        /// 消息发送对象的用户ID
        ///</summary>
        public int Msgto { get; set; } // msgto

        ///<summary>
        /// 消息是否己被对方阅读标记。Y－己读。N－未读
        ///</summary>
        public string Isread { get; set; } // isread

        ///<summary>
        /// 接收者阅读消息的时间
        ///</summary>
        public System.DateTime? Readdt { get; set; } // readdt

        ///<summary>
        /// 用户是否删除该消息。Y－己删;N－未删;用户在删时只更新这个字段，并不真删，下次用户看不到这条消息了，但网站管理员可以看到这个消息，并用标识为用户己经删除此条消息，网站管理员可以真正删除这条消息
        ///</summary>
        public string Isdelete { get; set; } // isdelete

        public SysMsg()
        {
            Isread = "‘N’";
            Isdelete = "N";
        }
    }
}