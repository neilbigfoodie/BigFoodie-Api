namespace BigFoodie.Model
{
    public class Advsearch
    {
        public int Advid { get; set; } // advid (Primary key)

        ///<summary>
        /// 广告所选的邮編第一部分
        ///</summary>
        public string Postcode { get; set; } // postcode

        ///<summary>
        /// 顺序号
        ///</summary>
        public int? Indexno { get; set; } // indexno

        ///<summary>
        /// 餐馆ID
        ///</summary>
        public string Shopid { get; set; } // shopid

        ///<summary>
        /// 广告有效开始时间
        ///</summary>
        public System.DateTime? Startdt { get; set; } // startdt

        ///<summary>
        /// 广告有效结束时间
        ///</summary>
        public System.DateTime? Enddt { get; set; } // enddt

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime? Createdt { get; set; } // createdt

        ///<summary>
        /// 创建人ID
        ///</summary>
        public string Createuser { get; set; } // createuser
    }
}