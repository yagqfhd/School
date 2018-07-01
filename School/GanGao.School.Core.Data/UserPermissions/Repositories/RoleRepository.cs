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
    ///     仓储操作实现——角色信息
    /// </summary>
    [Export(typeof(IRoleRepository))]
    public class RoleRepository : EFRepositoryBase<SysRole<string>>, IRoleRepository { }
}