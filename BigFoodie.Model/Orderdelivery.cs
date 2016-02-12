namespace BigFoodie.Model
{
    public class Orderdelivery
    {

        ///<summary>
        /// 订单号
        ///</summary>
        public string Orderid { get; set; } // orderid (Primary key)

        ///<summary>
        /// 送货地址部分1
        ///</summary>
        public string Addr1 { get; set; } // addr1

        ///<summary>
        /// 送货地址部分2
        ///</summary>
        public string Addr2 { get; set; } // addr2

        ///<summary>
        /// 送货地址部分3
        ///</summary>
        public string Addr3 { get; set; } // addr3

        ///<summary>
        /// 收货人所在的城市
        ///</summary>
        public string Townname { get; set; } // townname

        ///<summary>
        /// 收货所在地邮編部分1
        ///</summary>
        public string Postcode1 { get; set; } // postcode1

        ///<summary>
        /// 收货所在地邮編部分2
        ///</summary>
        public string Postcode2 { get; set; } // postcode2

        ///<summary>
        /// 收货联系人姓名
        ///</summary>
        public string Contactname { get; set; } // contactname

        ///<summary>
        /// 收货人联系电话1
        ///</summary>
        public string Tel1 { get; set; } // tel1

        ///<summary>
        /// 收货人联系电话2.mobile
        ///</summary>
        public string Tel2 { get; set; } // tel2

        ///<summary>
        /// 送餐时间
        ///</summary>
        public System.DateTime? Deliverdt { get; set; } // deliverdt

        ///<summary>
        /// 送餐人名
        ///</summary>
        public string Deliverpeople { get; set; } // deliverpeople

        ///<summary>
        /// 送餐时的附加信息
        ///</summary>
        public string Comments { get; set; } // comments
    }
}