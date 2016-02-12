namespace BigFoodie.Model
{
    public class Userscore
    {

        ///<summary>
        /// 主键ID，自动增长
        ///</summary>
        public int Sid { get; set; } // sid (Primary key)

        ///<summary>
        /// 用户ID
        ///</summary>
        public int? Uid { get; set; } // uid

        ///<summary>
        /// 获取积分的时间
        ///</summary>
        public System.DateTime? Scoretime { get; set; } // scoretime

        ///<summary>
        /// 操作用户
        ///</summary>
        public string Operateuser { get; set; } // operateuser

        ///<summary>
        /// 积分值
        ///</summary>
        public int? Score { get; set; } // score

        ///<summary>
        /// 积分值正负值。+表示奖励积分，-表示消费积分
        ///</summary>
        public string Operation { get; set; } // operation

        ///<summary>
        /// 积分类型: 0.表示推荐用户得分，1.表示评价得分
        ///</summary>
        public string Scoretype { get; set; } // scoretype

        ///<summary>
        /// 积分事由描述
        ///</summary>
        public string Description { get; set; } // description
    }
}