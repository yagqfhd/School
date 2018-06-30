
using System.ComponentModel;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 部门角色类定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    [Description("部门角色类，用于验证权限")]
    public class DepartmentRole<TKey> : IDepartmentRole<TKey>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public  TKey RoleId { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public  TKey DepartmentId { get; set; }
    }
    /// <summary>
    /// 部门角色类定义
    /// </summary>
    public class DepartmentRole : DepartmentRole<string> { }
    
}