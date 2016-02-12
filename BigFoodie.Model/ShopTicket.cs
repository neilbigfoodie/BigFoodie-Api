namespace BigFoodie.Model
{
    public class ShopTicket
    {

        ///<summary>
        /// 主鍵ID
        ///</summary>
        public int Id { get; set; } // id (Primary key)

        ///<summary>
        /// 消费券ID
        ///</summary>
        public string Ticketid { get; set; } // ticketid

        ///<summary>
        /// 优惠券的名字
        ///</summary>
        public string Ticketname { get; set; } // ticketname

        ///<summary>
        /// 消费券的描述
        ///</summary>
        public string Ticketdesc { get; set; } // ticketdesc

        ///<summary>
        /// 消费券面值金额.
        ///</summary>
        public int Ticketvalue { get; set; } // ticketvalue

        ///<summary>
        /// 券类型（备用）
        ///</summary>
        public string Tickettype { get; set; } // tickettype

        ///<summary>
        /// 券有效时间
        ///</summary>
        public System.DateTime? Starttime { get; set; } // starttime

        ///<summary>
        /// 券结束时间
        ///</summary>
        public System.DateTime? Endtime { get; set; } // endtime

        ///<summary>
        /// 券是否有效
        ///</summary>
        public string Isvalid { get; set; } // isvalid

        ///<summary>
        /// 生成人的用户ID（管理员ID）
        ///</summary>
        public string Operateid { get; set; } // operateid

        ///<summary>
        /// 优惠券的生成时间
        ///</summary>
        public System.DateTime? CreateDt { get; set; } // createDT

        ///<summary>
        /// 领用人的ID
        ///</summary>
        public int? Applyuid { get; set; } // applyuid

        ///<summary>
        /// 此券是否己经被使用。Y－被使用。N－尚未使用.
        ///</summary>
        public string Isused { get; set; } // isused

        ///<summary>
        /// 领用时间
        ///</summary>
        public System.DateTime? Applydt { get; set; } // applydt

        ///<summary>
        /// 领用者使用券时的订单号
        ///</summary>
        public int? ApplyOrderId { get; set; } // applyOrderID

        ///<summary>
        /// 在哪个商家使用了该券
        ///</summary>
        public int? Shopid { get; set; } // shopid

        public ShopTicket()
        {
            Isused = "N";
        }
    }
}