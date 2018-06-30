using GanGao.Component.Tools;
using GanGao.School.Core.ViewModels.UserPermissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.UserPermissions
{
    public interface IUserService
    {
        #region 属性

        #endregion

        #region 公共方法

        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> Login(UserLoginInfoViewInput loginInfo);

        /// <summary>
        ///     用户退出登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> Logout(UserLoginInfoViewInput loginInfo);

        #endregion
    }
}
