
using System.Collections.Generic;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 用户类 接口定义
    /// </summary>
    public interface IUser<TKey> : IEntity<TKey>
    {
        /// <summary>
        /// 加密保存的密码
        /// </summary>
        string PasswordHash { get; set; }
        /// <summary>
        /// 用户电话号码
        /// </summary>
        string PhoneNumber { get; set; }
        /// <summary>
        /// 用户联系邮箱
        /// </summary>
        string Email { get; set; }
        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        string TrueName { get; set; }
        /// <summary>
        /// 用户昵称
        /// </summary>
        string Nick { get; set; }
        /// <summary>
        /// 用户的部门集合
        /// </summary>
        ICollection<UserDepartment<TKey>> Departments { get;  }
    }

    /// <summary>
    /// 用户ID  接口定义
    /// </summary>
    public interface IUserId<TKey>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        TKey UserId { get; set; }
    }

    /// <summary>
    /// 用户部门  接口
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IUserDepartment<TKey> : IUserId<TKey>, IDepartmentId<TKey>// IEntityDepartment<TKey> { }
    {
        /// <summary>
        /// 本部门实体
        /// </summary>
        SysDepartment<TKey> Department { get; }
        // 所属角色集合
        ICollection<UserDepartmentRole<TKey>> Roles { get; }
    }
    /// <summary>
    /// 用户部门角色接口
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IUserDepartmentRole<TKey> : IUserId<TKey>, IDepartmentId<TKey>, IRoleId<TKey>//: IEntityDepartmentRole<TKey> { }
    {
        SysRole<TKey> Role { get; }
    }

}
