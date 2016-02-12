namespace BigFoodie.Model
{
    public class SysLog
    {

        ///<summary>
        /// 主键字段，自动增长
        ///</summary>
        public decimal Logid { get; set; } // logid (Primary key)

        ///<summary>
        /// 操作者用户ID
        ///</summary>
        public string Userid { get; set; } // userid

        ///<summary>
        /// 操作事由描述
        ///</summary>
        public string Actstr { get; set; } // actstr

        ///<summary>
        /// 操作时间
        ///</summary>
        public System.DateTime Actdt { get; set; } // actdt

        ///<summary>
        /// 日志重要度
        ///</summary>
        public string Priority { get; set; } // priority
    }
}