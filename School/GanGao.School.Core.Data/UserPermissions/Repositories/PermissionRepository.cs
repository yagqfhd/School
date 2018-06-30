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
    ///     仓储操作实现——角色信息
    /// </summary>
    [Export(typeof(IPermissionRepository))]
    public class PermissionRepository : EFRepositoryBase<SysPermission<string>>, IPermissionRepository { }
    /// <summary>
    ///     仓储操作实现——角色信息
    /// </summary>
    [Export(typeof(IPermissionDepartmentRepository))]
    public class PermissionDepartmentRepository : EFRepositoryBase<PermissionDepartment<string>>, IPermissionDepartmentRepository { }
    /// <summary>
    ///     仓储操作实现——角色信息
    /// </summary>
    [Export(typeof(IPermissionDepartmentRoleRepository))]
    public class PermissionDepartmentRoleRepository : EFRepositoryBase<PermissionDepartmentRole<string>>, IPermissionDepartmentRoleRepository { }

}