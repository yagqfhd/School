using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.Data.Infrastructure
{
    /// <summary>
    ///     仓储操作接口——部门信息
    /// </summary>
    public interface IDepartmentRepository : IRepository<SysDepartment<string>>
    {
    }
}
