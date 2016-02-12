namespace BigFoodie.Model
{
    public class Shopviewtelrecord
    {
        public decimal Infoid { get; set; } // infoid (Primary key)

        ///<summary>
        /// Restaurent id
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 电话查看时间
        ///</summary>
        public System.DateTime Viewdt { get; set; } // viewdt

        ///<summary>
        /// 电话查看次数
        ///</summary>
        public int? Viewcount { get; set; } // viewcount
    }
}