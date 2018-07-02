using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GanGao.School.OAuth.Providers
{
    public class GanGaoOptionService
    {
        public static OAuthAuthorizationServerOptions ServerOptions()
        {
            return new OAuthAuthorizationServerOptions
            {
                //AccessTokenProvider = new SchoolAuthenticationTokenProvider(),
                TokenEndpointPath = new PathString("/Token"),
                RefreshTokenProvider = new GanGaoRefreshTokenProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                AllowInsecureHttp = true,
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,
                Provider = new GanGaoAuthorizationServerProvider()
            };
        }

        public static OAuthBearerAuthenticationOptions BearerOptions()
        {
            return new OAuthBearerAuthenticationOptions();
        }
    }
}