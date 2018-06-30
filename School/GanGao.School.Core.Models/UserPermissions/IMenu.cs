
using System.Collections.Generic;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 菜单类 接口定义
    /// </summary>
    public interface IMenu<TKey> : IEntity<TKey>
    {
        /// <summary>
        /// 菜单的部门集合
        /// </summary>
        ICollection<IMenuDepartment<TKey>> Departments { get; }
    }

    /// <summary>
    /// 菜单ID 接口定义
    /// </summary>
    public interface IMenuId<TKey>
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        TKey MenuId { get; set; }
    }

    /// <summary>
    /// 菜单部门类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IMenuDepartment<TKey> : IMenuId<TKey>, IDepartmentId<TKey> //IEntityDepartment<TKey> { }
    {
    }
    /// <summary>
    /// 菜单部门角色类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IMenuDepartmentRole<TKey> : IMenuId<TKey>, IDepartmentId<TKey>,IRoleId<TKey>//: IEntityDepartmentRole<TKey> { }
    { }
}