namespace BigFoodie.Model
{
    public class CreditCard
    {

        ///<summary>
        /// 主键，自动增长
        ///</summary>
        public int Cardid { get; set; } // cardid (Primary key)

        ///<summary>
        /// 持卡人uID，＝userReg.UID
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 卡号或帐号
        ///</summary>
        public string Acct { get; set; } // ACCT

        ///<summary>
        /// 信用卡类：0 = Visa;  1 = MasterCard;  8 = Other;  9 = Switch;  S = Solo;
        ///</summary>
        public string AcctType { get; set; } // AcctType

        ///<summary>
        /// 持卡人帐单地址，包括门牌号和街道名
        ///</summary>
        public string Street { get; set; } // Street

        ///<summary>
        /// 持卡人帐单城市
        ///</summary>
        public string City { get; set; } // city

        ///<summary>
        /// 持卡人帐单州名
        ///</summary>
        public string State { get; set; } // state

        ///<summary>
        /// 持卡人帐单国家代号
        ///</summary>
        public string Country { get; set; } // country

        ///<summary>
        /// 邮编
        ///</summary>
        public string Zip { get; set; } // zip

        ///<summary>
        /// 此卡的发卡次数。Switch或Solo卡，交易时，需要确认CARDISSUE或者CARDSTART。
        ///</summary>
        public int? CardIssue { get; set; } // cardIssue

        ///<summary>
        /// Switch或Solo卡的发卡日期，为mmyy格式，如0308代表2008年3月
        ///</summary>
        public string CardStart { get; set; } // cardStart

        ///<summary>
        /// 卡的有效期，为mmyy格式
        ///</summary>
        public string ExpDate { get; set; } // expDate

        ///<summary>
        /// 持卡人名
        ///</summary>
        public string FirstName { get; set; } // firstName

        ///<summary>
        /// 持卡人姓
        ///</summary>
        public string LastName { get; set; } // lastName

        ///<summary>
        /// 卡验证码。信用卡公司要求这个内容网站不可保存。
        ///</summary>
        public string Cvv2 { get; set; } // CVV2

        ///<summary>
        /// 卡信息的创建时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // createDT
    }
}