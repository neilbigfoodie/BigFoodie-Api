namespace BigFoodie.Model
{
    public class CustomerReview
    {
        public int Reviewid { get; set; } // reviewid (Primary key)

        ///<summary>
        /// 评论人,uid=userreg.uid
        ///</summary>
        public int? Uid { get; set; } // uid

        ///<summary>
        /// 评论人的邮件地址，供未注册用户使用
        ///</summary>
        public string Email { get; set; } // email

        ///<summary>
        /// 对质量的评分
        ///</summary>
        public decimal? Rate1 { get; set; } // rate1

        ///<summary>
        /// 对送餐速度的评分
        ///</summary>
        public decimal? Rate2 { get; set; } // rate2

        ///<summary>
        /// 对服务的评分
        ///</summary>
        public decimal? Rate3 { get; set; } // rate3

        ///<summary>
        /// 评分平均值
        ///</summary>
        public decimal? Rate4 { get; set; } // rate4

        ///<summary>
        /// 评论时间
        ///</summary>
        public System.DateTime? ReviewDate { get; set; } // reviewDate

        ///<summary>
        /// 评论对象类型。1:订单名; 2:菜单
        ///</summary>
        public string Reviewtype { get; set; } // reviewtype

        ///<summary>
        /// 被评论对象的ID，为2时对应菜单表里的主键ID
        ///</summary>
        public int? Objid { get; set; } // objid

        ///<summary>
        /// 所评论的订单ID
        ///</summary>
        public string Orderid { get; set; } // orderid

        ///<summary>
        /// 评论内容
        ///</summary>
        public string Comment { get; set; } // comment

        ///<summary>
        /// 餐馆对评论的回复信息.(no use)
        ///</summary>
        public string ReplyMsg { get; set; } // replyMsg

        ///<summary>
        /// 评论回复时间(no use)
        ///</summary>
        public System.DateTime? ReplyDt { get; set; } // replyDT

        ///<summary>
        /// 所属餐馆/商家的ID。
        ///</summary>
        public int Shopid { get; set; } // shopid

        ///<summary>
        /// 评论的用户名称
        ///</summary>
        public string Username { get; set; } // username

        ///<summary>
        /// 评论者所在的城市
        ///</summary>
        public string Townname { get; set; } // townname

        public CustomerReview()
        {
            Uid = 0;
        }
    }
}