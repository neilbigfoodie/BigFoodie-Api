namespace BigFoodie.Model
{
    public class ShoppingCart
    {

        ///<summary>
        /// 主索引键，自动增长号
        ///</summary>
        public int Cartid { get; set; } // cartid (Primary key)

        ///<summary>
        /// 顾客ID，如果是未登录用户，则为0
        ///</summary>
        public int? CustomerId { get; set; } // customerID

        ///<summary>
        /// 顾客的sessionID,唯一值
        ///</summary>
        public string CustomerSessionId { get; set; } // customerSessionID

        ///<summary>
        /// 购物蓝创建时间
        ///</summary>
        public System.DateTime? CreatedOn { get; set; } // CreatedOn

        ///<summary>
        /// 购物蓝最后更新时间
        ///</summary>
        public System.DateTime? UpdateOn { get; set; } // UpdateOn

        ///<summary>
        /// 此餐所属商家ID
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 主产品ID号
        ///</summary>
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// 此餐所含主食的ID号
        ///</summary>
        public int? Mainfoodid { get; set; } // mainfoodid

        ///<summary>
        /// 套餐产品ID号(主产品号可能有多个子产品),多个字产品用，号隔开
        ///</summary>
        public string SubProductId { get; set; } // SubProductID

        ///<summary>
        /// 主物品的数量
        ///</summary>
        public int? Quantity { get; set; } // Quantity
        public string MenuOptionIDs { get; set; } // MenuOptionIDs

        public ShoppingCart()
        {
            CustomerId = 0;
            Quantity = 1;
        }
    }
}