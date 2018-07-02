// 源文件头信息：
// <copyright file="EFDbContext.cs">
// Copyright(c)2012-2013 GanGaoCN.All rights reserved.
// CLR版本：4.0.30319.239
// 开发组织：郭明锋@中国
// 公司网站：http://www.GanGaocn.net
// 所属工程：GanGao.Component.Data
// 最后修改：郭明锋
// 最后修改：2013/06/14 22:57
// </copyright>

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using GanGao.Component.Tools;
using System.ComponentModel.Composition;

namespace GanGao.Component.Data
{
    /// <summary>
    ///     EF数据访问上下文
    /// </summary>
    [Export("DbContext",typeof(EFDbContext))]
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("default") { }

        public EFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        [ImportMany]
        public IEnumerable<IEntityMapper> EntityMappers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            if (EntityMappers == null)
            {
                //return;
                throw PublicHelper.ThrowDataAccessException("实体映射对象个数为0，创建DbContext上下文对象失败。");
            }

            foreach (var mapper in EntityMappers)
            {
                mapper.RegistTo(modelBuilder.Configurations);
            }
        }
    }
}