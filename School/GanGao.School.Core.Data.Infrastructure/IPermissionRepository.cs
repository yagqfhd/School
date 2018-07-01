using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;

namespace GanGao.School.Core.Data.Infrastructure
{
    /// <summary>
    ///     仓储操作接口——权限信息
    /// </summary>
    public interface IPermissionRepository : IRepository<SysPermission<string>>
    { }

    /// <summary>
    ///     仓储操作接口——权限部门信息
    /// </summary>
    public interface IPermissionDepartmentRepository : IRepository<PermissionDepartment<string>>
    { }

    /// <summary>
    ///     仓储操作接口——权限部门信息
    /// </summary>
    public interface IPermissionDepartmentRoleRepository : IRepository<PermissionDepartmentRole<string>>
    { }
}
