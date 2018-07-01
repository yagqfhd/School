﻿using GanGao.Component.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.UserPermissions.Validators
{
    /// <summary>
    /// 校验接口
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IValidator<TEntity>
    {
        /// <summary>
        /// 校验核心
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Task<OperationResult> ValidateAsync(TEntity item);
    }
}
