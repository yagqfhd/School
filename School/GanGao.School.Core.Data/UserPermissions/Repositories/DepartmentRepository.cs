using GanGao.Component.Data;
using GanGao.School.Core.Data.Infrastructure;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.Data.UserPermissions.Repositories
{
    /// <summary>
    ///     仓储操作实现——部门信息
    /// </summary>
    [Export(typeof(IDepartmentRepository))]
    public class DepartmentRepository : EFRepositoryBase<SysDepartment<string>>, IDepartmentRepository { }
}