using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.Data.UserPermissions.Repositories
{
    /// <summary>
    ///     仓储操作实现——用户信息
    /// </summary>
    [Export(typeof(IUserRepository))]
    public class UserRepository : EFRepositoryBase<SysUser>, IUserRepository { }
    /// <summary>
    ///     仓储操作实现——用户部门信息
    /// </summary>
    [Export(typeof(IUserDepartmentRepository))]
    public class UserDepartmentRepository : EFRepositoryBase<UserDepartment>, IUserDepartmentRepository { }
    /// <summary>
    ///     仓储操作实现——用户部门角色信息
    /// </summary>
    [Export(typeof(IUserDepartmentRoleRepository))]
    public class UserDepartmentRoleRepository : EFRepositoryBase<UserDepartmentRole>, IUserDepartmentRoleRepository { }

}