namespace BigFoodie.Model
{
    public class OnlineUser
    {
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 在线用户id
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 在线用户名字
        ///</summary>
        public string Urealname { get; set; } // urealname

        ///<summary>
        /// 登录时间
        ///</summary>
        public System.DateTime? LoginTime { get; set; } // loginTime

        ///<summary>
        /// 最后更新时间
        ///</summary>
        public System.DateTime? LastUpdateTime { get; set; } // lastUpdateTime

        ///<summary>
        /// 登录用户类型：0表示普通用户.1表示商家用户
        ///</summary>
        public string Utype { get; set; } // utype

        public OnlineUser()
        {
            LoginTime = System.DateTime.Now;
            LastUpdateTime = System.DateTime.Now;
        }
    }
}