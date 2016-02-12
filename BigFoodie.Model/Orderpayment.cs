namespace BigFoodie.Model
{
    public class Orderpayment
    {

        ///<summary>
        /// 表主键，自动增长
        ///</summary>
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 订单号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 卡号
        ///</summary>
        public string Cardnumber { get; set; } // cardnumber

        ///<summary>
        /// 卡类型.数据跟creditCard.cardtype保持一致
        ///</summary>
        public string Cardtype { get; set; } // cardtype

        ///<summary>
        /// 持卡人名
        ///</summary>
        public string Name1 { get; set; } // name1

        ///<summary>
        /// 持卡人姓
        ///</summary>
        public string Name2 { get; set; } // name2

        ///<summary>
        /// 付款时间
        ///</summary>
        public System.DateTime? Paidtime { get; set; } // paidtime

        ///<summary>
        /// 提交付信息时间
        ///</summary>
        public System.DateTime? Applytime { get; set; } // applytime

        ///<summary>
        /// 客服/店铺管理员确认付款时间
        ///</summary>
        public System.DateTime? Confirmtime { get; set; } // confirmtime

        ///<summary>
        /// 本次支付总金额
        ///</summary>
        public decimal? Paidamount { get; set; } // paidamount

        ///<summary>
        /// 支付结果描述。主要存储信用卡或PAYPAL的网上支付的结果。字段内对应部分待定
        ///</summary>
        public string ResultDesc { get; set; } // resultDesc

        ///<summary>
        /// 是否有退款，缺省是N。若为Y，则需读取退款表：OrdepaymentRet查看详细记录
        ///</summary>
        public string Isret { get; set; } // isret
        public string Securauthstr { get; set; } // securauthstr

        public Orderpayment()
        {
            Isret = "N";
        }
    }
}