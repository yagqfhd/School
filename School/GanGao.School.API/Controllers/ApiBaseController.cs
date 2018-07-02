using GanGao.School.API.App_Start;
using GanGao.School.Core.Models.UserPermissions;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace GanGao.School.API.Controllers
{
    /// <summary>
    /// API控制器基类
    /// </summary>
    public class ApiBaseController : ApiController
    {
        #region /////// 获取 OwinContext 对象
        private OwinContext _owinContext = null;
        /// <summary>
        /// OwinContext
        /// </summary>
        protected OwinContext owinContext
        {
            get
            {
                if (_owinContext == null)
                    _owinContext = GetProperties(PropertiesKeys.OwinContext) as OwinContext;
                return _owinContext;
            }
        }
        #endregion

        #region //// 当前登录用户对象
        private SysUser _curUser = null;
        protected SysUser curUser
        {
            get
            {
                if (_curUser == null)
                    _curUser = GetProperties(PropertiesKeys.LoginUser) as SysUser;
                return _curUser;
            }
        }
        #endregion

        #region ///////// 内部使用方法
        /// <summary>
        /// 获取指定属性
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private object GetProperties(string key)
        {
            object result = null;
            Request.Properties.TryGetValue(key, out result);
            return result;
        }

        /// <summary>
        /// 获取模型验证错误信息
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        protected string GetModelStateError(ModelStateDictionary status)
        {
            string error = string.Empty;
            foreach (var key in status.Keys)
            {
                var state = status[key];
                if (state.Errors.Any())
                {
                    error = state.Errors.First().ErrorMessage;
                    break;
                }
            }
            return error;
        }
        
        #endregion

        #region ///// 常用对象定义
       
        #endregion
    }
}
