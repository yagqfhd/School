using GanGao.Component.Tools;
using GanGao.School.Core.Data.UserPermissions.Repositories;
using GanGao.School.Core.Models.UserPermissions;
using GanGao.School.Core.UserPermissions.Validators;
using GanGao.School.Core.ViewModels.UserPermissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GanGao.School.Core.UserPermissions
{
    public class UserService : CoreServiceBase, IUserService
    {
        #region 属性

        #region 受保护的属性

        /// <summary>
        /// 获取或设置 用户信息数据访问对象
        /// </summary>
        [Import]
        protected IUserRepository UserRepository { get; set; }

        /// <summary>
        /// 获取或设置 用户部门信息数据访问对象
        /// </summary>
        [Import]
        protected IUserDepartmentRepository UserDepartmentRepository { get; set; }

        /// <summary>
        /// 获取或设置 用户部门角色信息数据访问对象
        /// </summary>
        [Import]
        protected IUserDepartmentRoleRepository UserDepartmentRoleRepository { get; set; }

        /// <summary>
        /// 获取或设置 用户信息校验对象
        /// </summary>
        [Import]
        IValidator<SysUser> UserValidator { get; set; }
        #endregion

        #endregion

        #region 方法实现

        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> Login(UserLoginInfoViewInput loginInfo)
        {
            PublicHelper.CheckArgument(loginInfo, "loginInfo");
            ///说明，这里配置了可以同时使用帐号，邮箱登录
            //获取用户
            var user = UserRepository.Entities.SingleOrDefault(m => m.Name == loginInfo.Access || m.Email == loginInfo.Access);
            if (user == null)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。"));
            }
            //校验密码
            if (user.PasswordHash != loginInfo.Password)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Warning, "登录密码不正确。"));
            }
            //记录登录信息
            //LoginLog loginLog = new LoginLog { IpAddress = loginInfo.IpAddress, Member = user };
            //LoginLogRepository.Insert(loginLog);
            return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Success, "登录成功。", user));
        }

        /// <summary>
        ///     用户退出登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> Logout(UserLoginInfoViewInput loginInfo)
        {
            PublicHelper.CheckArgument(loginInfo, "loginInfo");
            ///说明，这里配置了可以同时使用帐号，邮箱登录
            //获取用户
            var user = UserRepository.Entities.SingleOrDefault(m => m.Name == loginInfo.Access || m.Email == loginInfo.Access);
            if (user == null)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。"));
            }
            //校验密码
            if (user.PasswordHash != loginInfo.Password)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Warning, "登录密码不正确。"));
            }
            //记录退出登录信息
            //LoginLog loginLog = new LoginLog { IpAddress = loginInfo.IpAddress, Member = user };
            //LoginLogRepository.Insert(loginLog);
            return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Success, "登录成功。", user));
        }

        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public virtual Task<OperationResult> ExistsByName(string userName)
        {
            PublicHelper.CheckArgument(userName, "userName");
            //获取用户
            var user = UserRepository.Entities.SingleOrDefault(m => m.Name == userName);
            if (user == null)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。"));
            }
            return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Success));
        }

        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public virtual Task<OperationResult> ExistsByEmail(string emailName)
        {
            PublicHelper.CheckArgument(emailName, "userName");
            //获取用户
            var user = UserRepository.Entities.SingleOrDefault(m => m.Email == emailName);
            if (user == null)
            {
                return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.QueryNull, "指定账号的用户不存在。"));
            }
            return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Success));
        }
        #endregion
    }
}