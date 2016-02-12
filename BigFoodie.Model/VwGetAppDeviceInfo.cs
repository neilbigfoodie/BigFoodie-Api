namespace BigFoodie.Model
{
    public class VwGetAppDeviceInfo
    {
        public int Deviceid { get; set; } // deviceid
        public string Devicetoken { get; set; } // devicetoken
        public string Devicetype { get; set; } // devicetype
        public string Deviceversion { get; set; } // deviceversion
        public System.DateTime? Registdt { get; set; } // registdt
        public string Channels { get; set; } // channels
        public System.DateTime? LastHeartbeatAt { get; set; } // LastHeartbeatAt
        public string Loginname { get; set; } // loginname
        public int? Shopid { get; set; } // shopid
    }
}