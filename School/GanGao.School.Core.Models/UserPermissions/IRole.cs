

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 角色类 接口定义
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IRole<TKey> : IEntity<TKey>
    {
    }

    /// <summary>
    /// 角色ID 接口定义
    /// </summary>
    public interface IRoleId<TKey>
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        TKey RoleId { get; set; }
    }
}
