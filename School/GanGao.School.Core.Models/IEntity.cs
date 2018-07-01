using GanGao.Component.Tools;
using System.Collections.Generic;

namespace GanGao.School.Core.Models
{
    /// <summary>
    /// 实体类  基类接口定义
    /// </summary>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// 主键定义
        /// </summary>
        TKey Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        string Description { get; set; }
    }

    /// <summary>
    /// 关联类 基类接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IRelation<TKey>
    {
        /// <summary>
        /// 主键定义
        /// </summary>
        TKey Id { get; set; }
    }

    /// <summary>
    /// 具有父子关系的类  基类接口定义
    /// </summary>
    public interface IParentChildRelation<TEntity> where TEntity : Entity
    {
        /// <summary>
        /// 上级，父级
        /// </summary>
        TEntity Parent { get; set; }
        /// <summary>
        /// 下级，子级集合
        /// </summary>
        ICollection<TEntity> Childs { get; set; }
    }

    ///// <summary>
    ///// 实体部门关联类 基类接口定义
    ///// </summary>
    ///// <typeparam name="TKey"></typeparam>
    //public interface IEntityDepartment<TKey> : IRelation<TKey>, IDepartmentId<TKey>
    //{
    //    /// <summary>
    //    /// 本部门实体
    //    /// </summary>
    //    IDepartment<TKey> Department { get; }
    //    // 所属角色集合
    //    ICollection<IEntityDepartmentRole<TKey>> Roles { get; }
    //}

    ///// <summary>
    ///// 实体部门角色关联类  基类接口定义
    ///// </summary>
    ///// <typeparam name="TKey"></typeparam>
    //public interface IEntityDepartmentRole<TKey> : IRelation<TKey>, IDepartmentId<TKey>, IRoleId<TKey>
    //{
    //    /// <summary>
    //    /// 本角色实体
    //    /// </summary>
    //    IRole<TKey> Role { get; }
    //}
}
