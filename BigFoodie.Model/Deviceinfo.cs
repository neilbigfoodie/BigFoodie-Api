namespace BigFoodie.Model
{
    public class Deviceinfo
    {
        public int Deviceid { get; set; } // deviceid (Primary key)

        ///<summary>
        /// 设备的ID
        ///</summary>
        public string Devicetoken { get; set; } // devicetoken

        ///<summary>
        /// 设备类型:android, ios
        ///</summary>
        public string Devicetype { get; set; } // devicetype

        ///<summary>
        /// 设备的操作系统对应的版本号
        ///</summary>
        public string Deviceversion { get; set; } // deviceversion

        ///<summary>
        /// 设备注册日期
        ///</summary>
        public System.DateTime? Registdt { get; set; } // registdt

        ///<summary>
        /// 设备注册后所属的Parse.com里的channel
        ///</summary>
        public string Channels { get; set; } // channels

        ///<summary>
        /// 这个台设备最后一次被使用时间
        ///</summary>
        public System.DateTime? LastHeartbeatAt { get; set; } // LastHeartbeatAt
    }
}