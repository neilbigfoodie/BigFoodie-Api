namespace BigFoodie.Model
{
    public class ShopExtInfoForApp
    {
        public int Shopid { get; set; } // shopid (Primary key)

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime Createdt { get; set; } // createdt

        ///<summary>
        /// 是否接收协议（合同）Y/N
        ///</summary>
        public string Isaccepted { get; set; } // isaccepted

        ///<summary>
        /// 接收协议时间
        ///</summary>
        public System.DateTime? Acceptdt { get; set; } // acceptdt

        ///<summary>
        /// 接收协议用户登录名
        ///</summary>
        public string Acceptuserid { get; set; } // acceptuserid

        ///<summary>
        /// 推荐人的用户ID
        ///</summary>
        public int? Recuserid { get; set; } // recuserid

        ///<summary>
        /// 支付的费用
        ///</summary>
        public decimal? Recamt { get; set; } // recamt

        ///<summary>
        /// 是否己支付Y/N
        ///</summary>
        public string Ispaidrec { get; set; } // ispaidrec

        ///<summary>
        /// 支付费用的时间
        ///</summary>
        public System.DateTime? Recpaiddt { get; set; } // recpaiddt

        ///<summary>
        /// 操作支付的管理员名称
        ///</summary>
        public string Operatename { get; set; } // operatename

        ///<summary>
        /// 餐馆的状态pending/offline/online
        ///</summary>
        public string Shopstatus { get; set; } // shopstatus
    }
}