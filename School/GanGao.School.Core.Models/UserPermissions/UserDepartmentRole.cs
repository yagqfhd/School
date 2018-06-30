using GanGao.Component.Tools;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 用户部门角色
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class UserDepartmentRole<TKey> :Entity , IUserDepartmentRole<TKey>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public TKey UserId { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public TKey DepartmentId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public TKey RoleId { get; set; }
        /// <summary>
        /// 对应的角色
        /// </summary>
        public virtual SysRole<TKey> Role { get; set; }
    }

    /// <summary>
    /// 用户部门角色
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class UserDepartmentRole : UserDepartmentRole<string> { }
}