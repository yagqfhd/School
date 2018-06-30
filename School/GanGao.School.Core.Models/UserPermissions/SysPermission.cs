using System.Collections.Generic;


namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 权限定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class SysPermission<TKey> : EntityBase<TKey>,IPermission<TKey>
    {
    }

    /// <summary>
    /// 权限定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class SysPermission : SysPermission<string>, IEntityDepartmentCollection<PermissionDepartment>
    {
        /// <summary>
        /// 权限部门集合
        /// </summary>
        public virtual ICollection<PermissionDepartment> Departments { get; protected set; }

        public SysPermission()
        {
            this.Departments = new HashSet<PermissionDepartment>();

        }
    }
}