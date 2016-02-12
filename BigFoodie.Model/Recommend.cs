namespace BigFoodie.Model
{
    public class Recommend
    {

        ///<summary>
        /// 表主键
        ///</summary>
        public int RecId { get; set; } // recID (Primary key)

        ///<summary>
        /// 推荐人的id
        ///</summary>
        public int? RecUid { get; set; } // recUid

        ///<summary>
        /// 推荐人的名字/Email
        ///</summary>
        public string RecName { get; set; } // recName

        ///<summary>
        /// 餐馆/外卖店名称
        ///</summary>
        public string Shopname { get; set; } // shopname

        ///<summary>
        /// 餐馆/外卖店所在的城市
        ///</summary>
        public string Townname { get; set; } // townname

        ///<summary>
        /// 期望配送的地区
        ///</summary>
        public string DeliveryArea { get; set; } // DeliveryArea

        ///<summary>
        /// 餐馆的详细地址
        ///</summary>
        public string Addr { get; set; } // addr

        ///<summary>
        /// 餐馆的联系电话
        ///</summary>
        public string Tel { get; set; } // tel

        ///<summary>
        /// 此条推荐消息是否己处理,Y己处理，N未处理。默认为N
        ///</summary>
        public string Ishandled { get; set; } // ishandled

        ///<summary>
        /// 处理结果：1。成功加盟些店；2。找不到些店；3。不加盟。成功加盟些店后，给推荐人发email，请他定餐。
        ///</summary>
        public string Status { get; set; } // status

        ///<summary>
        /// 推荐时间
        ///</summary>
        public System.DateTime? RecDate { get; set; } // recDate

        public Recommend()
        {
            Ishandled = "’N''";
        }
    }
}