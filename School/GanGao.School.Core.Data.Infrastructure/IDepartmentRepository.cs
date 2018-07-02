using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;

namespace GanGao.School.Core.Data.Infrastructure
{
    /// <summary>
    ///     仓储操作接口——部门信息
    /// </summary>
    public interface IDepartmentRepository : IRepository<SysDepartment<string>>
    {
    }
}
