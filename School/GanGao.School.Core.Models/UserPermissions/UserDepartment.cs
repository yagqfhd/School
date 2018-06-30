using GanGao.Component.Tools;
using System.Collections.Generic;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 用户部门实体对象
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class UserDepartment<TKey>  : Entity, IUserDepartment<TKey>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public TKey UserId { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public TKey DepartmentId { get; set; }
        /// <summary>
        /// 部门实体
        /// </summary>
        public virtual SysDepartment<TKey> Department { get; }
        /// <summary>
        /// 部门下的角色集合
        /// </summary>
        public virtual ICollection<UserDepartmentRole<TKey>> Roles { get; }
    }

    /// <summary>
    /// 用户部门实体对象
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public class UserDepartment : UserDepartment<string> { }
}