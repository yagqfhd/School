using GanGao.Component.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanGao.School.Core.Infrastructure
{
    /// <summary>
    /// 服务层标准建删更新 接口定义
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface ICoreService<TEntity,TKey>
        where TEntity : class
    {
        /// <summary>
        /// 创建实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OperationResult> CreateAsync(TEntity entity);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OperationResult> DeleteAsync(TEntity entity);
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<OperationResult> DeleteAsync(TKey key);
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OperationResult> UpdateAsync(TEntity entity);
    }
}
