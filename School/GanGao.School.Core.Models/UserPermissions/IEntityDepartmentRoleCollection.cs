using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 实体于部门于角色集合 接口定义
    /// </summary>
    public interface IEntityDepartmentRoleCollection<TEntityDepartmentRole>
        where TEntityDepartmentRole : class
    {
        /// <summary>
        /// 部门下的角色集合
        /// </summary>
        ICollection<TEntityDepartmentRole> Roles { get; }
    }
}
