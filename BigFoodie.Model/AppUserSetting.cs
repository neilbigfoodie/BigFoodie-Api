namespace BigFoodie.Model
{
    public class AppUserSetting
    {

        ///<summary>
        /// 关联用户表AppUserInfo.appuserid
        ///</summary>
        public int Appuserid { get; set; } // appuserid (Primary key)

        ///<summary>
        /// 用户操作权限代码: counter用户有效.0-接单 1-查看帐单 2-查询历史订单 3-删除订单
        ///</summary>
        public string Operatecode { get; set; } // operatecode

        ///<summary>
        /// 是否接单 1-接单 0-不接单
        ///</summary>
        public string Istakeorder { get; set; } // istakeorder

        ///<summary>
        /// 新订单提示音
        ///</summary>
        public string Neworderalertfile { get; set; } // neworderalertfile

        ///<summary>
        /// 信息提示音
        ///</summary>
        public string Infoalertfile { get; set; } // infoalertfile

        ///<summary>
        /// 普通员工是否当班 1-当班 0-不当班，不当班需填写日期
        ///</summary>
        public string Onduty { get; set; } // onduty

        ///<summary>
        /// 不当班到期时间，包括日期\时间
        ///</summary>
        public System.DateTime? Offdutytodt { get; set; } // offdutytodt

        ///<summary>
        /// APP端用户语言版本0-中文 1-英文
        ///</summary>
        public string Langopt { get; set; } // langopt

        public AppUserSetting()
        {
            Langopt = "1";
        }
    }
}