namespace GanGao.Hash
{
    /// <summary>
    /// 密码校验生成 接口
    /// </summary>
    public interface IPasswordValidator
    {
        /// <summary>
        /// 生成密码
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        string HashPassword(string password);
        /// <summary>
        /// 校验密码正确性
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool VerifyHashedPassword(string passwordHash, string password);
    }
}