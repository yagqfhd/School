namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 部门类 接口定义
    /// </summary>
    public interface IDepartment<TKey> : IEntity<TKey>
    {
    }
    /// <summary>
    /// 部门角色类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IDepartmentRole<TKey> : IRoleId<TKey>, IDepartmentId<TKey>
    {
    }

    /// <summary>
    /// 部门ID 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IDepartmentId<TKey>
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        TKey DepartmentId { get; set; }
    }
}