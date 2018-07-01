using GanGao.Component.Tools;
using GanGao.School.Core.Models.UserPermissions;
using GanGao.School.Core.ViewModels.UserPermissions;
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
        Task<OperationResult> Login(UserLoginInfoViewInput loginInfo);

        /// <summary>
        ///     用户退出登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> Logout(UserLoginInfoViewInput loginInfo);
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<OperationResult> ExistsByName(string userName);
        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="emailName"></param>
        /// <returns></returns>
        Task<OperationResult> ExistsByEmail(string emailName);
        #endregion

        #region /// 用户增删改


        #endregion

        #region //// 用户查询
        /// <summary>
        /// 按照ID查询用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<SysUser> FindById(string id);
        /// <summary>
        /// 按照名次查询用户
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<SysUser> FindByName(string name);
        /// <summary>
        /// 按照Email查询用户
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<SysUser> FindByEmail(string email);
        /// <summary>
        /// 按照用户名获取Email查询用户
        /// </summary>
        /// <param name="access"></param>
        /// <returns></returns>
        Task<SysUser> FindUser(string access);
        /// <summary>
        /// 根据用户名或Email，密码获取用户
        /// </summary>
        /// <param name="access"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<SysUser> FindUser(string access, string password);
        #endregion

        #endregion
    }
}
