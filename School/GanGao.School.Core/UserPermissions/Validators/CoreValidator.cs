using GanGao.Component.Data;
using GanGao.Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GanGao.School.Core.UserPermissions.Validators
{
    /// <summary>
    /// 核心业务数据校验实现基类
    /// </summary>
    public abstract class CoreValidator<TEntity>
    {
        public virtual Task<OperationResult> ValidateAsync(TEntity item)
        {
            return Task.FromResult<OperationResult>(new OperationResult(OperationResultType.Success));
        }
    }
}