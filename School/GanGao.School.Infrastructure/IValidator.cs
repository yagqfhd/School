using GanGao.Component.Tools;
using System.Threading.Tasks;

namespace GanGao.School.Core.Infrastructure
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
