namespace BigFoodie.Model
{
    public class DeliveryAddr
    {

        ///<summary>
        /// 用户送货地址表主键
        ///</summary>
        public int Addrid { get; set; } // addrid (Primary key)

        ///<summary>
        /// 收货人名称
        ///</summary>
        public string Username { get; set; } // username

        ///<summary>
        /// 用户ID，＝userReg.UID
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 地址项名称。基本的地址项取名为Basic，其它新建的地址不能用此名
        ///</summary>
        public string Addrname { get; set; } // addrname

        ///<summary>
        /// 详细地址的第1部分
        ///</summary>
        public string Addr1 { get; set; } // addr1

        ///<summary>
        /// 详细地址的第2部分
        ///</summary>
        public string Addr2 { get; set; } // addr2

        ///<summary>
        /// 详细地址的第3部分
        ///</summary>
        public string Addr3 { get; set; } // addr3

        ///<summary>
        /// 所在的城市名
        ///</summary>
        public string Cityname { get; set; } // cityname

        ///<summary>
        /// 所在地址邮编第1部分
        ///</summary>
        public string Postcode1 { get; set; } // postcode1

        ///<summary>
        /// 所在地址邮编第2部分
        ///</summary>
        public string Postcode2 { get; set; } // postcode2

        ///<summary>
        /// 联系电话1
        ///</summary>
        public string Tel { get; set; } // tel

        ///<summary>
        /// 此配送地址的附加信息
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 记录标识符，备用
        ///</summary>
        public string Flag { get; set; } // flag

        ///<summary>
        /// 移动电话
        ///</summary>
        public string Mobile { get; set; } // mobile
    }
}