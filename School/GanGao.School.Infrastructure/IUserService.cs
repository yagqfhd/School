using GanGao.Component.Tools;
using GanGao.School.Core.Models.UserPermissions;
using GanGao.School.Core.ViewModels.UserPermissions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GanGao.School.Core.Infrastructure
{
    /// <summary>
    /// 服务层 用户信息服务接口
    /// </summary>
    public interface IUserService : ICoreService<SysUser,string>
    {
        #region 属性

        #endregion

        #region 公共方法 
        #region /// 用户登录相关
        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> LoginAsync(UserLoginInfoViewInput loginInfo);

        /// <summary>
        ///     用户退出登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> LogoutAsync(UserLoginInfoViewInput loginInfo);
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<OperationResult> ExistsByNameAsync(string userName);
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="emailName"></param>
        /// <returns></returns>
        Task<OperationResult> ExistsByEmailAsync(string emailName);
        /// <summary>
        /// 校验用户名称密码
        /// </summary>
        /// <param name="access"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<OperationResult> ValidatorUserAsync(string access, string password);
        #endregion

        #region /// 用户增删改


        #endregion

        #region //// 用户查询
        /// <summary>
        /// 按照ID查询用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<SysUser> FindByIdAsync(string id);
        /// <summary>
        /// 按照名次查询用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<SysUser> FindByNameAsync(string name);
        /// <summary>
        /// 按照Email查询用户
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<SysUser> FindByEmailAsync(string email);
        /// <summary>
        /// 按照用户名获取Email查询用户
        /// </summary>
        /// <param name="access"></param>
        /// <returns></returns>
        Task<SysUser> FindUserAsync(string access);
        /// <summary>
        /// 根据用户名或Email，密码获取用户
        /// </summary>
        /// <param name="access"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<SysUser> FindUserAsync(string access, string password);
        #endregion

        #region ///// 分页相关
        /// <summary>
        /// 获取指定页用户集合
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Limit"></param>
        /// <param name="Order"></param>
        /// <returns></returns>
        Task<IEnumerable<SysUser>> UserPageListAsync(int Index, int Limit, string Order);
        #endregion
        #endregion
    }
}
