

using GanGao.Component.Tools;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 权限部门角色定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class PermissionDepartmentRole<TKey> : Entity, IPermissionDepartmentRole<TKey>
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        public TKey PermissionId { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public TKey DepartmentId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public TKey RoleId { get; set; }
        
    }

    /// <summary>
    /// 权限部门角色定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class PermissionDepartmentRole : PermissionDepartmentRole<string>
    {
        /// <summary>
        /// 对应的角色
        /// </summary>
        public virtual SysRole Role { get; set; }
    }
}