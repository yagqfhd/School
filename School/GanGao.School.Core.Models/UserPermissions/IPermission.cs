
using System.Collections.Generic;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 权限类  接口定义
    /// </summary>
    public interface IPermission<TKey> : IEntity<TKey>
    {
        
    }

    /// <summary>
    /// 权限ID 接口定义
    /// </summary>
    public interface IPermissionId<TKey>
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        TKey PermissionId { get; set; }
    }

    /// <summary>
    /// 权限部门类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IPermissionDepartment<TKey> : IPermissionId<TKey>, IDepartmentId<TKey> 
    {
        /// <summary>
        /// 本部门实体
        /// </summary>
        SysDepartment<TKey> Department { get; }
        // 所属角色集合
        //ICollection<PermissionDepartmentRole<TKey>> Roles { get; }
    }
    
    /// <summary>
    /// 权限部门角色类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IPermissionDepartmentRole<TKey> : IPermissionId<TKey>, IDepartmentId<TKey>,IRoleId<TKey> //: IEntityDepartmentRole<TKey> { }
    {
        SysRole<TKey> Role { get; }
    }
}