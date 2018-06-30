using GanGao.Component.Tools;
using GanGao.School.Core.Models.UserPermissions;
using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 权限部门定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    [Description("权限部门类，用于关联权限部门类")]
    public class PermissionDepartment<TKey> :Entity, IPermissionDepartment<TKey>
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
        /// 部门实体
        /// </summary>
        public virtual SysDepartment<TKey> Department { get; }
        

        
    }

    /// <summary>
    /// 权限部门定义
    /// </summary>    
    public class PermissionDepartment : PermissionDepartment<string> , IEntityDepartmentRoleCollection<PermissionDepartmentRole>
    {
        /// <summary>
        /// 部门下的角色集合
        /// </summary>
        public virtual ICollection<PermissionDepartmentRole> Roles { get; }
    }
}