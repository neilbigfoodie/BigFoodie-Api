namespace BigFoodie.Model
{
    public class AppUserInfo
    {
        public int Appuserid { get; set; } // appuserid (Primary key)

        ///<summary>
        /// 餐馆ID
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 用户登录名
        ///</summary>
        public string Loginname { get; set; } // loginname
        public string Password { get; set; } // password

        ///<summary>
        /// 用户类型：0-老板用户 1-COUNTER 2-司机
        ///</summary>
        public string Usertype { get; set; } // usertype

        ///<summary>
        /// 用户真实姓名
        ///</summary>
        public string Username { get; set; } // username

        ///<summary>
        /// 用户状态 1:有效 0-锁定
        ///</summary>
        public string Status { get; set; } // status

        ///<summary>
        /// 登录时间
        ///</summary>
        public System.DateTime? Logindt { get; set; } // logindt

        ///<summary>
        /// 用户创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 创建人
        ///</summary>
        public string Createuser { get; set; } // createuser

        ///<summary>
        /// 用户登录IP
        ///</summary>
        public string Loginip { get; set; } // loginip

        ///<summary>
        /// 登录状态 Y-为登录，N为退出
        ///</summary>
        public string Loginstatus { get; set; } // loginstatus

        ///<summary>
        /// 连续错误登录次数
        ///</summary>
        public int? LoginErrCount { get; set; } // LoginErrCount

        ///<summary>
        /// 用户登录后生成，并返回给客户端的令牌，客户端每次访问接口需要提供这个TOKEN。
        ///</summary>
        public string Apptokenstr { get; set; } // apptokenstr

        public AppUserInfo()
        {
            LoginErrCount = 0;
        }
    }
}