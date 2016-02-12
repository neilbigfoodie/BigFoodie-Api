namespace BigFoodie.Model
{
    public class Newshopregi
    {
        public int Regisid { get; set; } // regisid (Primary key)

        ///<summary>
        /// 店名
        ///</summary>
        public string Shopname { get; set; } // shopname

        ///<summary>
        /// 地址第一行
        ///</summary>
        public string Addr1 { get; set; } // addr1

        ///<summary>
        /// 地址第二行
        ///</summary>
        public string Addr2 { get; set; } // addr2

        ///<summary>
        /// 城市
        ///</summary>
        public string Cityname { get; set; } // cityname

        ///<summary>
        /// 邮编
        ///</summary>
        public string Postcode { get; set; } // postcode

        ///<summary>
        /// 联系人
        ///</summary>
        public string Contactperson { get; set; } // contactperson

        ///<summary>
        /// 联系电话
        ///</summary>
        public string Tele { get; set; } // tele

        ///<summary>
        /// 注册时间
        ///</summary>
        public System.DateTime? Regisdt { get; set; } // regisdt

        ///<summary>
        /// 后台处理管理员用户名
        ///</summary>
        public string SalesUserName { get; set; } // SalesUserName

        ///<summary>
        /// 是否己加盟Y-是； N-没有
        ///</summary>
        public string IsJoined { get; set; } // IsJoined

        ///<summary>
        /// 用于sales记录跟进的信息。
        ///</summary>
        public string Comments { get; set; } // Comments
    }
}