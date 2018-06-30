namespace GanGao.School.Core.Models.UserPermissions
{
    /// <summary>
    /// 角色定义 
    /// </summary>
    public class SysRole<TKey> : EntityBase<TKey>, IRole<TKey>            
    {        
    }

    /// <summary>
    /// 角色定义 
    /// </summary>
    public class SysRole : SysRole<string> { }


}