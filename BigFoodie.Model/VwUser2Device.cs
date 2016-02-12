namespace BigFoodie.Model
{
    public class VwUser2Device
    {
        public int? Shopid { get; set; } // shopid
        public int? Appuserid { get; set; } // appuserid
        public string Devicetoken { get; set; } // devicetoken
        public string Devicetype { get; set; } // devicetype
        public string Deviceversion { get; set; } // deviceversion
        public System.DateTime? Registdt { get; set; } // registdt
        public string Channels { get; set; } // channels
        public System.DateTime? LastHeartbeatAt { get; set; } // LastHeartbeatAt
        public int Deviceid { get; set; } // deviceid
    }
}