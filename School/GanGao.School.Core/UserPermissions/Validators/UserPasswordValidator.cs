using GanGao.Component.Tools;
using GanGao.Hash;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.UserPermissions.Validators
{
    /// <summary>
    /// 用户密码校验生成
    /// </summary>
    [Export(typeof(IPasswordValidator))]
    public class UserPasswordValidator : DefaultPasswordValidatorHandler
    {
    }
}