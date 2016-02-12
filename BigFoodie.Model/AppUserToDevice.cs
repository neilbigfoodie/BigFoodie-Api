namespace BigFoodie.Model
{
    public class AppUserToDevice
    {

        ///<summary>
        /// 顺序号
        ///</summary>
        public decimal Infoid { get; set; } // infoid (Primary key)

        ///<summary>
        /// 设备的ID（对应deviceinfo.devicetoken）
        ///</summary>
        public string Devicetoken { get; set; } // devicetoken

        ///<summary>
        /// 餐馆ID.用户登录后填写此值.注销后则删除此值
        ///</summary>
        public int? Shopid { get; set; } // shopid

        ///<summary>
        /// 对应AppUserInfo里用户主键.用户在客户端登录成功则填写，注销时删除此值
        ///</summary>
        public int? Appuserid { get; set; } // appuserid
    }
}