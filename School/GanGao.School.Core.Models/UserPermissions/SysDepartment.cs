using System.Collections.Generic;

namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 部门定义
    /// </summary>
    public class SysDepartment<TKey> : EntityBase<TKey>, IDepartment<TKey>, IParentChildRelation<SysDepartment<TKey>>
    {
        /// <summary>
        /// 上级部门
        /// </summary>
        public virtual SysDepartment<TKey> Parent { get; set; }
        /// <summary>
        /// 下级部门集合
        /// </summary>
        public virtual ICollection<SysDepartment<TKey>> Childs { get; set; }

        #region ///////// 构造器

        //public SysDepartment()
        //{
        //    Childs = new HashSet<SysDepartment<TKey>>();
        //}
        #endregion
    }

    /// <summary>
    /// 部门定义
    /// </summary>
    public class SysDepartment : SysDepartment<string> { }

}