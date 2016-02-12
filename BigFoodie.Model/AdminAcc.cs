namespace BigFoodie.Model
{
    public class AdminAcc
    {
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 管理员登录帐号
        ///</summary>
        public string Loginname { get; set; } // loginname

        ///<summary>
        /// 管理员登录密码
        ///</summary>
        public string Loginpwd { get; set; } // loginpwd

        ///<summary>
        /// 帐号创建时间
        ///</summary>
        public System.DateTime? Createtime { get; set; } // createtime

        ///<summary>
        /// 管理员权限代码，多个用分号隔开,如001,002等
        ///</summary>
        public string Rightcode { get; set; } // rightcode

        ///<summary>
        /// 最近登录时间
        ///</summary>
        public System.DateTime? Lastlogindt { get; set; } // lastlogindt

        ///<summary>
        /// 最近登录ip
        ///</summary>
        public string Lastloginip { get; set; } // lastloginip

        ///<summary>
        /// 用户帐号是否有效.Y有效，N。无效，用户暂无法登录，缺省为Y
        ///</summary>
        public string Isvalid { get; set; } // isvalid

        ///<summary>
        /// 是否超级管理员Y，是，N不是。缺省为N
        ///</summary>
        public string Isadmin { get; set; } // isadmin

        public AdminAcc()
        {
            Isvalid = "Y";
            Isadmin = "N";
        }
    }
}