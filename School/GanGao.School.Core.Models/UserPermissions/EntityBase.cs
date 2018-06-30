using GanGao.Component.Tools;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 实体基类。
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public abstract class EntityBase<TKey> :Entity, IEntity<TKey>
    {
        /// <summary>
        /// ID
        /// </summary>
        public TKey Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }
        
    }
}