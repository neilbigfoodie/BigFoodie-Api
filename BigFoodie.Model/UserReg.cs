namespace BigFoodie.Model
{
    public class UserReg
    {

        ///<summary>
        /// 0是普通用户;T-Takeway餐馆管理用员;R-Restaurant用户;
        ///</summary>
        public string Utype { get; set; } // utype

        ///<summary>
        /// 性别:0.女/Miss; 1:男/Mr.
        ///</summary>
        public string Gender { get; set; } // gender

        ///<summary>
        /// 用户姓名
        ///</summary>
        public string Realname { get; set; } // realname

        ///<summary>
        /// 邮箱地址（登录名）
        ///</summary>
        public string Email { get; set; } // email

        ///<summary>
        /// 用户登录密码
        ///</summary>
        public string Pwd { get; set; } // pwd

        ///<summary>
        /// 密码保护问题
        ///</summary>
        public string Pwdquestion { get; set; } // pwdquestion

        ///<summary>
        /// 密码保护问题的答案
        ///</summary>
        public string Pwdanswer { get; set; } // pwdanswer

        ///<summary>
        /// 生日.格式如:1970/10/1
        ///</summary>
        public string Birthday { get; set; } // birthday

        ///<summary>
        /// 最后登录日期
        ///</summary>
        public System.DateTime? Lastlogindate { get; set; } // lastlogindate

        ///<summary>
        /// 最后登录IP
        ///</summary>
        public string LastloginIp { get; set; } // lastloginIP

        ///<summary>
        /// 用户是否被锁定。Y.锁定，用户将无法登录。 N: 未锁定，缺省值为'N'
        ///</summary>
        public string Islocked { get; set; } // islocked

        ///<summary>
        /// 用户目前总积分数.具体积分记录见积分详细表
        ///</summary>
        public int? Score { get; set; } // score
        public int? Credits { get; set; } // credits

        ///<summary>
        /// 是否被列入黑名单. Y.是，N。否.缺省值为N
        ///</summary>
        public string Isblocked { get; set; } // isblocked

        ///<summary>
        /// 是否愿意通过邮件接受网站通知消息.Y愿意。N不愿意。缺省值为Y
        ///</summary>
        public string Isnoticed { get; set; } // isnoticed

        ///<summary>
        /// 帐号创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 用户登录错误次数, 累积登录超过6次则锁定此户。如果在后台解锁时，则将此次数清0
        ///</summary>
        public int? LoginErrTime { get; set; } // loginErrTime
        public int Uid { get; set; } // uid (Primary key)
        public string Houseno { get; set; } // houseno
        public string Addr1 { get; set; } // addr1
        public string Postcode1 { get; set; } // postcode1
        public string Postcode2 { get; set; } // postcode2

        public UserReg()
        {
            Islocked = "N";
            Score = 0;
            Credits = 0;
            Isblocked = "N";
            Isnoticed = "Y";
            LoginErrTime = 0;
        }
    }
}