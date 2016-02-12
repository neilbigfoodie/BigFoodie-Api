namespace BigFoodie.Model
{
    public class Ordernotice
    {

        ///<summary>
        /// 主码
        ///</summary>
        public string Scode { get; set; } // scode (Primary key)

        ///<summary>
        /// 商家ID号
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 订单ID号
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 信息查看有效时间
        ///</summary>
        public System.DateTime ExpiredDt { get; set; } // ExpiredDT

        ///<summary>
        /// 用户查看时间
        ///</summary>
        public System.DateTime? Accessdt { get; set; } // accessdt

        ///<summary>
        /// 用户访问IP
        ///</summary>
        public string Accessip { get; set; } // accessip

        ///<summary>
        /// 是否己查看.Y-己读 N-未读
        ///</summary>
        public string Isread { get; set; } // isread

        public Ordernotice()
        {
            Isread = "N";
        }
    }
}