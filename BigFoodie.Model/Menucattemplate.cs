namespace BigFoodie.Model
{
    public class Menucattemplate
    {
        public int Catid { get; set; } // catid (Primary key)

        ///<summary>
        /// 序号
        ///</summary>
        public decimal? Indexnum { get; set; } // indexnum

        ///<summary>
        /// 类别名称
        ///</summary>
        public string Catname { get; set; } // catname

        ///<summary>
        /// 类别英文名
        ///</summary>
        public string Catname2 { get; set; } // catname2

        ///<summary>
        /// 备用字段
        ///</summary>
        public string Cat001 { get; set; } // cat001
    }
}