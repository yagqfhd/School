using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.ViewModels.UserPermissions
{
    /// <summary>
    ///     登录信息类ViewModel
    /// </summary>
    public class UserLoginInfoView
    {
        /// <summary>
        ///     获取或设置 登录账号
        /// </summary>
        public string Access { get; set; }

        /// <summary>
        ///     获取或设置 登录密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///     获取或设置 IP地址
        /// </summary>
        public string IpAddress { get; set; }
    }
    /// <summary>
    ///     登录信息类ViewModel 用于输入
    /// </summary>
    public class UserLoginInfoViewInput : UserLoginInfoView { }

}