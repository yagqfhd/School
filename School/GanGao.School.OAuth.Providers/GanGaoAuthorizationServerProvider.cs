using GanGao.School.Core.Infrastructure;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GanGao.School.OAuth.Providers
{
    /// <summary>
    /// OWIN.OAuth驱动
    /// </summary>
    public class GanGaoAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        #region ///// 私有变量属性定义
        //private readonly string _publicClientId = "GanGao.School";
        /// <summary>
        /// 用户服务
        /// </summary>
        [Import]
        private IUserService userService { get; set; }
        #endregion

        #region ////// 方法实现
        /// <summary>
        /// 通过调用来验证请求的源是否为已注册的“client_id”，
        /// 以及请求中是否存在该客户端的正确凭据。 
        /// 如果 Web 应用程序接受基本身份验证凭据，
        /// 则可以调用 context.TryGetBasicCredentials(out clientId, out clientSecret) 
        /// 来获取这些值（如果在请求标头中存在）。 
        /// 如果 Web 应用程序接受“client_id”和“client_secret”作为窗体编码 POST 参数，
        /// 则可以调用 context.TryGetFormCredentials(out clientId, out clientSecret) 来获取这些值（如果在请求正文中存在）。
        /// 如果未调用 context.Validated，则请求将不会继续执行。
        /// </summary>
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }

        /// <summary>
        /// 在对令牌终结点的请求到达时“grant_type”为“password”的情况下调用。 
        /// 在用户已将名称和密码凭据直接提供到客户端应用程序的用户界面中，
        /// 而客户端应用程序正在使用这些凭据获取“access_token”和可选的“refresh_token”时，
        /// 将发生这种情况。 如果 Web 应用程序支持资源所有者凭据授权类型，
        /// 则它必须根据情况验证 context.Username 和 context.Password。 
        /// 若要颁发访问令牌，调用 context.Validated 时必须使用新票证，
        /// 其中包含应与访问令牌关联的资源所有者的相关声明。 
        /// 默认行为是拒绝此授权类型。 另请参阅 http://tools.ietf.org/html/rfc6749#section-4.3.2
        /// </summary>
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            #region //////// 检查参数
            if (string.IsNullOrEmpty(context.UserName))
            {
                context.SetError("invalid_username", "username is not valid");
                return;
            }
            if (string.IsNullOrEmpty(context.Password))
            {
                context.SetError("invalid_password", "password is not valid");
                return;
            }
            #endregion

            #region ///// 用户检查
            /// 检查用户是否存在 及密码是否正确
            var user = await userService.FindUserAsync(context.UserName, context.Password);
            if (user==null)
            {
                var signResult = await userService.ValidatorUserAsync(context.UserName, context.Password);
                context.SetError("invalid_grant", signResult.Message);
                return;
            }            
            #endregion

            #region /////// 生成ClaimsIdentity
            
            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
            oAuthIdentity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            var properties = new AuthenticationProperties(new Dictionary<string, string>
            {
                { "userName", context.UserName  }
            });
            var ticket = new AuthenticationTicket(oAuthIdentity, properties);
            #endregion

            context.Validated(ticket); /// OAuth验证通过            
            context.Request.Context.Authentication.SignIn(oAuthIdentity);
            return;
        }

        /// <summary>
        /// 在成功的令牌终结点请求的最后阶段调用。 
        /// 应用程序可以实现此调用，以便对要用于颁发访问令牌或刷新令牌的声明进行任何最终修改。
        /// 还可以使用此调用向令牌终结点的 json 响应正文添加附加响应参数。
        /// </summary>
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {            
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }
            return base.TokenEndpoint(context);         
        }

        /// <summary>
        /// 在对令牌终结点的请求到达时“grant_type”为“refresh_token”的情况下调用。 
        /// 如果应用程序已颁发“refresh_token”和“access_token”，
        /// 而客户端正在尝试使用“refresh_token”获取新的“access_token”
        /// 以及“refresh_token”（可能是新的），将发生这种情况。 
        /// 若要颁发刷新令牌，必须分配 Options.RefreshTokenProvider 以创建返回值。
        /// 与刷新令牌关联的声明和属性存在于 context.Ticket 中。 
        /// 应用程序必须调用 context.Validated，才能指示授权服务器中间件基于这些声明和属性颁发访问令牌。 
        /// 可能会向对 context.Validated 的调用提供不同的 AuthenticationTicket 或 ClaimsIdentity，
        /// 以控制哪些信息从刷新令牌流到访问令牌。 
        /// 使用 OAuthAuthorizationServerProvider 时的默认行为是让信息在不做修改的情况下从刷新令牌流到访问令牌。
        /// 另请参阅 http://tools.ietf.org/html/rfc6749#section-6
        /// </summary>
        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            // Change auth ticket for refresh token requests
            var newIdentity = new ClaimsIdentity(context.Ticket.Identity);

            var newClaim = newIdentity.Claims.Where(c => c.Type == "newClaim").FirstOrDefault();
            if (newClaim != null)
            {
                newIdentity.RemoveClaim(newClaim);
            }
            newIdentity.AddClaim(new Claim("newClaim", "newValue"));

            var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
            context.Validated(newTicket);

            return Task.FromResult<object>(null);
        }
        #endregion
    }
}