using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.Data.UserPermissions.Repositories
{
    /// <summary>
    ///     仓储操作接口——用户信息
    /// </summary>
    public interface IUserRepository : IRepository<SysUser>
    {
    }

    /// <summary>
    ///     仓储操作接口——用户部门信息
    /// </summary>
    public interface IUserDepartmentRepository : IRepository<UserDepartment>
    {
    }

    /// <summary>
    ///     仓储操作接口——用户部门信息
    /// </summary>
    public interface IUserDepartmentRoleRepository : IRepository<UserDepartmentRole>
    {
    }
}
