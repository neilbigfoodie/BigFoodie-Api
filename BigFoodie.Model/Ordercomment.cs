namespace BigFoodie.Model
{
    public class Ordercomment
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Cid { get; set; } // cid (Primary key)

        ///<summary>
        /// 订单号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 留言类型。1表示此条留言为店长。2，表示此条留言为用户，此种类型留言可以由店长回复一条.
        ///</summary>
        public string Msgtype { get; set; } // msgtype

        ///<summary>
        /// 留言内容
        ///</summary>
        public string Msgcont { get; set; } // msgcont

        ///<summary>
        /// 留言回复的内容
        ///</summary>
        public string Msgreply { get; set; } // msgreply

        ///<summary>
        /// 留言创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 留言回复的时间
        ///</summary>
        public string Replydt { get; set; } // replydt
    }
}