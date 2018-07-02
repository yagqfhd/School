// 源文件头信息：
// <copyright file="EFRepositoryContext.cs">
// Copyright(c)2012-2013 GanGaoCN.All rights reserved.
// CLR版本：4.0.30319.239
// 开发组织：郭明锋@中国
// 公司网站：http://www.GanGaocn.net
// 所属工程：GanGao.Component.Data
// 最后修改：郭明锋
// 最后修改：2013/06/14 23:06
// </copyright>

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace GanGao.Component.Data
{
    /// <summary>
    ///     数据单元操作类
    /// </summary>
    [Export(typeof (IUnitOfWork))]
    internal class EFRepositoryContext : UnitOfWorkContextBase
    {
        /// <summary>
        ///     获取 当前使用的数据访问上下文对象
        /// </summary>
        protected override DbContext Context
        {
            get { return EFDbContext; }
        }

        [Import("DbContext")]
        private EFDbContext EFDbContext { get; set; }
    }
}