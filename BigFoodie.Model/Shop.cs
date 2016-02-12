namespace BigFoodie.Model
{
    public class Shop
    {

        ///<summary>
        /// 餐馆ID=UserReg.UID
        ///</summary>
        public int Shopid { get; set; } // shopid (Primary key)

        ///<summary>
        /// 商家名字。（主语言：英语）
        ///</summary>
        public string Sname { get; set; } // sname

        ///<summary>
        /// 商家名称，（第二语言）
        ///</summary>
        public string Sname2 { get; set; } // sname2

        ///<summary>
        /// 餐馆餐类，1-中餐，2-pizza,…可由系统管理员维护(一个餐馆可能属于多种餐类,用，号隔开)
        ///</summary>
        public string Mealtype { get; set; } // mealtype

        ///<summary>
        /// 晚餐送餐服务类型，1-送和取，2-只取，3-只送，4-只店吃
        ///</summary>
        public string ServiceType { get; set; } // serviceType

        ///<summary>
        /// 午餐送餐服务类型，1-送和取，2-只取，3-只送，4-只店吃
        ///</summary>
        public string ServiceTypeL { get; set; } // serviceTypeL

        ///<summary>
        /// 商家联系电话1
        ///</summary>
        public string Tel1 { get; set; } // tel1

        ///<summary>
        /// 商家联系电话2
        ///</summary>
        public string Tel2 { get; set; } // tel2

        ///<summary>
        /// 商家传真号码
        ///</summary>
        public string Fax { get; set; } // fax

        ///<summary>
        /// 商家联系邮件地址
        ///</summary>
        public string Email { get; set; } // email

        ///<summary>
        /// 是否用此邮件接收网站提示信息
        ///</summary>
        public string Gotnotice { get; set; } // gotnotice

        ///<summary>
        /// 商家联系人(经理)名称
        ///</summary>
        public string Contactname { get; set; } // contactname

        ///<summary>
        /// 联系人手机
        ///</summary>
        public string ContactTel { get; set; } // contactTel

        ///<summary>
        /// 餐馆所在地址一
        ///</summary>
        public string Addr1 { get; set; } // addr1

        ///<summary>
        /// 餐馆所在地址二
        ///</summary>
        public string Addr2 { get; set; } // addr2

        ///<summary>
        /// 餐馆所在地址三
        ///</summary>
        public string Addr3 { get; set; } // addr3

        ///<summary>
        /// 餐馆所在城市
        ///</summary>
        public string Cityname { get; set; } // cityname

        ///<summary>
        /// 餐馆所在地址邮编部分1
        ///</summary>
        public string Postcode1 { get; set; } // postcode1

        ///<summary>
        /// 餐馆所在地址邮編二
        ///</summary>
        public string Postcode2 { get; set; } // postcode2

        ///<summary>
        /// 商家所在的经度(预留)
        ///</summary>
        public string Longitude { get; set; } // longitude

        ///<summary>
        /// 商家所在的纬度（预留）
        ///</summary>
        public string Latitude { get; set; } // latitude

        ///<summary>
        /// 餐馆logo图片地址
        ///</summary>
        public string Logo { get; set; } // logo

        ///<summary>
        /// 是否启用VAT， Y 启用，N表示不启用，默认为N，一旦启用，就会读取配置文件里由系统管理员配置好的值.
        ///</summary>
        public string Vat { get; set; } // VAT

        ///<summary>
        /// 餐馆地图字符串(暂不实现8.15)
        ///</summary>
        public string Mapstr { get; set; } // mapstr

        ///<summary>
        /// 餐馆订餐信息描述
        ///</summary>
        public string Description { get; set; } // description

        ///<summary>
        /// 餐馆对味道的评分星级
        ///</summary>
        public decimal? Star1 { get; set; } // star1

        ///<summary>
        /// 对送餐速度的评分星级
        ///</summary>
        public decimal? Star2 { get; set; } // star2

        ///<summary>
        /// 餐馆对服务的评分的评分星级
        ///</summary>
        public decimal? Star3 { get; set; } // star3

        ///<summary>
        /// 餐馆对推荐度评分的评分星级
        ///</summary>
        public decimal? Star4 { get; set; } // star4

        ///<summary>
        /// 信息更新时间
        ///</summary>
        public System.DateTime? UpdateTime { get; set; } // updateTime

        ///<summary>
        /// 本店是否为网上订餐优惠活动加盟店,Y表示是，其它表示不是，缺省为不是
        ///</summary>
        public string Flag1 { get; set; } // flag1

        ///<summary>
        /// 餐馆的别名，用来做URL转发用
        ///</summary>
        public string Alias { get; set; } // alias

        ///<summary>
        /// 接收客人付款方式：1-Cash  2-Credit/Debit Card & Paypal  (可以组合)
        ///</summary>
        public string Acceptpay { get; set; } // acceptpay

        ///<summary>
        /// 订单语言的显示.Y-显示;N-不显示
        ///</summary>
        public string Orderlang { get; set; } // orderlang

        ///<summary>
        /// 接受订单的方式,C.表示用电脑.F表示用传真，S表示用短信，E表示用Email.可以组合，比如。C,F表示既可以用电脑，也可以用传真方式接受订单
        ///</summary>
        public string Acceptorder { get; set; } // acceptorder

        ///<summary>
        /// 配送方式.0-按距离配送; 1-按指定邮編配送.如果此值为空，表示默认配送区域为餐馆邮編第一部分的数字前的部分
        ///</summary>
        public string DeliveryWay { get; set; } // deliveryWay

        ///<summary>
        /// 这个店最长的送餐时间,即一份订单从收到要多久会送到客人手中
        ///</summary>
        public string Deliverytime { get; set; } // Deliverytime

        ///<summary>
        /// 是指送餐的订单在此店关门前多久可以订购,因为做餐加上送餐时间会超过此店的营业时间,所以送餐的单要提前订.
        ///</summary>
        public string DeliveryLastOt { get; set; } // DeliveryLastOT

        ///<summary>
        /// 最少起送金额
        ///</summary>
        public decimal? DeliveryMinOrder { get; set; } // DeliveryMinOrder

        ///<summary>
        /// 餐馆开户银行名称
        ///</summary>
        public string Bankname { get; set; } // bankname

        ///<summary>
        /// 餐馆开户银行户主名
        ///</summary>
        public string Bankusername { get; set; } // bankusername

        ///<summary>
        /// 银行Sort code
        ///</summary>
        public string Banksortcode { get; set; } // banksortcode

        ///<summary>
        /// 开户银行帐号号码
        ///</summary>
        public string Bankno { get; set; } // bankno

        ///<summary>
        /// 网站的佣金.
        ///</summary>
        public decimal? Webcommision { get; set; } // webcommision

        ///<summary>
        /// 佣金有效时间
        ///</summary>
        public System.DateTime? Expireddt { get; set; } // expireddt
        public string Bgpicture { get; set; } // bgpicture

        ///<summary>
        /// 0-不承担(默认值) 1-按比例承担 2-按固定值承担 .默认值为0
        ///</summary>
        public string Cardchargeopt { get; set; } // cardchargeopt
        public decimal? Fixchargeamt { get; set; } // fixchargeamt
        public decimal? Ratiochargeamt { get; set; } // ratiochargeamt
        public int? SuggestOnlineNum { get; set; } // suggestOnlineNum

        ///<summary>
        /// OO, TO, BI
        ///</summary>
        public string AcceptCustomerOpt { get; set; } // acceptCustomerOpt

        public Shop()
        {
            Star1 = 0m;
            Orderlang = "N'N'";
            Cardchargeopt = "0";
            SuggestOnlineNum = 0;
        }
    }
}