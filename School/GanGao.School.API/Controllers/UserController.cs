using GanGao.School.Core.Infrastructure;
using GanGao.School.Core.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GanGao.School.API.Controllers
{
    public class UserController : ApiBaseController
    {
        /// <summary>
        /// 用户服务
        /// </summary>
        [Import]
        private IUserService userService { get; set; }

        [Description("获取用户列表")]
        public IHttpActionResult PostUsers([FromBody]PageViewInput page)
        {
            #region //// Contracts 参数检查
            if (page == null)
                return BadRequest(String.Format(
                    CultureInfo.CurrentCulture, 
                    Resources.ParaIsNull, 
                    typeof(PageViewInput).Name
                 ));
            if (!ModelState.IsValid) return BadRequest(this.GetModelStateError(ModelState));
            #endregion

            // 获取用户部门ID集合
            //var depIds = curUser.Departments.Select(d => d.DepartmentId);
            // 获取 用户集合
            var users = userService.UserPageListAsync(page.Index, page.Limit, page.Order).GetAwaiter().GetResult();

            var result = new PageViewOutput
            {
                Index = page.Index,
                Limit = page.Limit,
                Message = users // .ToUserListView()
            };
            return Ok<PageViewOutput>(result);
        }
    }
}
