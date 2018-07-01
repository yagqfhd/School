using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GanGao.Hash
{
    /// <summary>
    /// 密码校验生成
    /// </summary>
    public class DefaultPasswordValidatorHandler : IPasswordValidator
    {
        /// <summary>
        /// 生成密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string PasswordHash(string password)
        {
            return password;
        }
        /// <summary>
        /// 校验密码正确性
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatorPassword(string passwordHash, string password)
        {
            return passwordHash == password;
        }
    }
}