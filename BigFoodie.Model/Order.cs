
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigFoodie.Model
{
    public class Order
    {

        ///<summary>
        /// 订单编号,可以按年月日+流水号的方式。固定长度为13位(8.15讨论)
        ///</summary>
        public string OrderId { get; set; } // OrderID (Primary key)

        ///<summary>
        /// 商家ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 下单人ID;非会员订购时，此值为0;
        ///</summary>
        public int Uid { get; set; } // uid

        ///<summary>
        /// 用户邮件地址。便于存放非会员订购数据
        ///</summary>
        public string Useremail { get; set; } // useremail

        ///<summary>
        /// 本餐的份数
        ///</summary>
        public int? Amount { get; set; } // amount

        ///<summary>
        /// 单价
        ///</summary>
        public decimal? Unitprice { get; set; } // unitprice

        ///<summary>
        /// 支付方式0.现金支付. 1,信用卡支付.2.Paypal支付..可扩展。除现金支付外的详细信息见orderpayment表
        ///</summary>
        public string Payway { get; set; } // payway

        ///<summary>
        /// 是否己支付.Y己支付。N未支付
        ///</summary>
        public string Ispaid { get; set; } // ispaid

        ///<summary>
        /// 如果用网站优惠券支付。此处填写优惠券号
        ///</summary>
        public string Ticketnumber { get; set; } // ticketnumber

        ///<summary>
        /// 优惠券面值
        ///</summary>
        public int? Ticketvalue { get; set; } // ticketvalue

        ///<summary>
        /// 取餐方式。0.上门自取; 1.送货上门(会在送货地址表里有详细情况)
        ///</summary>
        public string Deliveryway { get; set; } // deliveryway

        ///<summary>
        /// 送/取餐时间
        ///</summary>
        public System.DateTime? Pickupdt { get; set; } // pickupdt

        ///<summary>
        /// 订单的备注消息
        ///</summary>
        public string Comments { get; set; } // comments

        ///<summary>
        /// 订单的状态: Processing,Cooking,Dispatched,Delivered,Reviewed,Cancelled
        ///</summary>
        public string Orderstatus { get; set; } // orderstatus

        ///<summary>
        /// 下单时间
        ///</summary>
        public System.DateTime? Ordercreatedt { get; set; } // ordercreatedt

        ///<summary>
        /// 订单更新时间
        ///</summary>
        public System.DateTime? OrderUpdatedt { get; set; } // orderUpdatedt

        ///<summary>
        /// 订单是否己取消
        ///</summary>
        public string IsCancelled { get; set; } // isCancelled

        ///<summary>
        /// 订单取消时间
        ///</summary>
        public System.DateTime? OrderCancelledDt { get; set; } // orderCancelledDT

        ///<summary>
        /// 订单取消原因描述
        ///</summary>
        public string CancelComments { get; set; } // cancelComments

        ///<summary>
        /// 划卡支付总额=afterdiscount(打折后价格) + creditcardCharge(使用信用卡支付的手续费用)+ deliverycharge(送餐费) + tips(小费)-ticketvalue(优惠券支付费用)
        ///</summary>
        public decimal? Totalamount { get; set; } // totalamount

        ///<summary>
        /// 订单内所有商品总金额（折扣前金额）
        ///</summary>
        public decimal? Totalprice1 { get; set; } // totalprice1

        ///<summary>
        /// 本次订单折扣率
        ///</summary>
        public decimal? DiscountRate { get; set; } // discountRate

        ///<summary>
        /// 订单折扣后总金额=totalprice1（商品总金额）* discountRate（商埸折扣率）
        ///</summary>
        public decimal? Afterdiscount { get; set; } // afterdiscount

        ///<summary>
        /// 本次配送费用，缺省是0
        ///</summary>
        public decimal? Deliverycharge { get; set; } // deliverycharge

        ///<summary>
        /// 此笔订单需支付的佣金.计算规则，由订单总金额×佣金比例(去Commission表里找)，如果此表没有，缺省取配置文件里的StandardCommission项
        ///</summary>
        public decimal? ServiceCharge { get; set; } // serviceCharge

        ///<summary>
        /// 信用卡网关的手续费,缺省是0
        ///</summary>
        public decimal? CreditcardCharge { get; set; } // creditcardCharge

        ///<summary>
        /// 本次订单的小费
        ///</summary>
        public decimal? Tips { get; set; } // tips

        ///<summary>
        /// 此订单是否己经对帐。N－没有，Y－己对帐
        ///</summary>
        public string Isjz { get; set; } // isjz

        ///<summary>
        /// 对帐时间
        ///</summary>
        public System.DateTime? Jzdt { get; set; } // jzdt

        ///<summary>
        /// 商家本次实际获取的金额，因为支付网关会收取相应的费用，所以跟totalamount会有区别
        ///</summary>
        public decimal? Actualamount { get; set; } // actualamount

        ///<summary>
        /// 下订单时用户的IP地址
        ///</summary>
        public string UserIp { get; set; } // userIP

        ///<summary>
        /// 是否新订单Y-是;N-不是。
        ///</summary>
        public string Isnew { get; set; } // isnew
        public decimal? Comrate { get; set; } // comrate
        public decimal? Shopcardcharge { get; set; } // shopcardcharge
        public decimal? Paidwithcredit { get; set; } // paidwithcredit
        public string Vouchercode { get; set; } // vouchercode
        public decimal? Creditback { get; set; } // creditback

        public Order()
        {
            Ispaid = "N";
            Ticketvalue = 0;
            Orderstatus = "Processing";
            DiscountRate = 1m;
            Deliverycharge = 0m;
            CreditcardCharge = 0m;
            Isjz = "N";
            Isnew = "Y";
            Comrate = 0m;
            Shopcardcharge = 0m;
        }
    }

}
