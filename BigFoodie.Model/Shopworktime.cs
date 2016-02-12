namespace BigFoodie.Model
{
    public class Shopworktime
    {

        ///<summary>
        /// 商家ID
        ///</summary>
        public int Shopid { get; set; } // shopid (Primary key)

        ///<summary>
        /// 周一开/关店时间段一,e.g: 08:00 - 11:00
        ///</summary>
        public string MonFrToA { get; set; } // monFrToA

        ///<summary>
        /// 周一开/关店时间段二,e.g: 17:00 -03:00
        ///</summary>
        public string MonFrToB { get; set; } // monFrToB

        ///<summary>
        /// 周二开/关店时间段一,e.g: 08:00 - 11:00
        ///</summary>
        public string TuesFrToA { get; set; } // tuesFrToA

        ///<summary>
        /// 周二开/关店时间段2,e.g: 08:00 - 11:00
        ///</summary>
        public string TuesFrToB { get; set; } // tuesFrToB

        ///<summary>
        /// 周三开/关店时间段1,e.g: 08:00 - 11:00
        ///</summary>
        public string WedFrToA { get; set; } // wedFrToA

        ///<summary>
        /// 周三开/关店时间段B,e.g: 08:00 - 11:00
        ///</summary>
        public string WedFrToB { get; set; } // wedFrToB

        ///<summary>
        /// 周四开/关店时间段1,e.g: 08:00 - 11:00
        ///</summary>
        public string ThurFrToA { get; set; } // thurFrToA

        ///<summary>
        /// 周四开/关店时间段2,e.g: 08:00 - 11:00
        ///</summary>
        public string ThurFrToB { get; set; } // thurFrToB

        ///<summary>
        /// 周五开/关店时间段1,e.g: 08:00 - 11:00
        ///</summary>
        public string FriFrToA { get; set; } // friFrToA

        ///<summary>
        /// 周五开/关店时间段2,e.g: 08:00 - 11:00
        ///</summary>
        public string FriFrToB { get; set; } // friFrToB

        ///<summary>
        /// 周六开/关店时间段1,e.g: 08:00 - 11:00
        ///</summary>
        public string SatFrToA { get; set; } // satFrToA

        ///<summary>
        /// 周六开/关店时间段2,e.g: 08:00 - 11:00
        ///</summary>
        public string SatFrToB { get; set; } // satFrToB

        ///<summary>
        /// 周日开/关店时间段1,e.g: 08:00 - 11:00
        ///</summary>
        public string SunFrToA { get; set; } // sunFrToA

        ///<summary>
        /// 周日开/关店时间段2,e.g: 08:00 - 11:00
        ///</summary>
        public string SunFrToB { get; set; } // sunFrToB

        ///<summary>
        /// 备用字段
        ///</summary>
        public string Wt001 { get; set; } // wt001

        ///<summary>
        /// 是否提供午餐Y-是,N-否
        ///</summary>
        public string Haslunch { get; set; } // haslunch
    }
}