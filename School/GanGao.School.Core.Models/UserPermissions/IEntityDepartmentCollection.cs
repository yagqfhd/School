using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 实体的部门集合 接口定义
    /// </summary>
    public interface IEntityDepartmentCollection<TEntityDepartment>
        where TEntityDepartment : class
    {
        /// <summary>
        /// 实体的部门集合
        /// </summary>
        ICollection<TEntityDepartment> Departments { get; }
    }
}
