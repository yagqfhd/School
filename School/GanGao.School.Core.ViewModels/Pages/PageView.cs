using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.ViewModels.Pages
{
    /// <summary>
    /// 分页显示模型
    /// </summary>
    public class PageView
    {
        /// <summary>
        /// 每页数
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// 页号
        /// </summary>
        public int Index { get; set; }
    }

    /// <summary>
    /// 分页显示模型输入模型
    /// </summary>
    public class PageViewInput : PageView
    {
        /// <summary>
        /// 排序字段
        /// </summary>
        public string Order { get; set; }

        
    }

    /// <summary>
    /// 分页显示模型输出模型
    /// </summary>
    public class PageViewOutput : PageView 
    {
        /// <summary>
        /// 输出对象
        /// </summary>
        public object Message { get; set; }
    }
}