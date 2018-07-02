using System;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Cors;
using GanGao.School.OAuth.Providers;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using GanGao.School.API.Models;
using System.Reflection;
//using System.ComponentModel.Composition;

[assembly: OwinStartup(typeof(GanGao.School.API.StartupAPI))]

namespace GanGao.School.API
{
    public class StartupAPI
    {
        public static string PublicClientId = "GanGao.School";
        
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();

            app.UseOAuthBearerAuthentication(GanGaoOptionService.BearerOptions());
            app.UseOAuthAuthorizationServer(GanGaoOptionService.ServerOptions());

            app.UseCors(CorsOptions.AllowAll);
            //这一行代码必须放在ConfiureOAuth(app)之后
            app.UseWebApi(config);
            WebApiConfig.Register(config);

            //设置MEF依赖注入容器
//var compositionHost = new ContainerConfiguration().WithAssemblies(new[]
//{
//    typeof(A).Assembly,
//    typeof(B).Assembly,
//    typeof(C).Assembly,
//    typeof(D).Assembly,
//}).CreateContainer();

            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(GanGao.School.API.Controllers.UserController).Assembly));
            APIDependencySolver solver = new APIDependencySolver(catalog);
            config.DependencyResolver = solver;
            ////catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            //_container = new CompositionContainer(catalog);
            //_container.GetExport()
            //DirectoryCatalog catalog = new DirectoryCatalog(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath);
            //MefDependencySolver solver = new MefDependencySolver(catalog);
        }    
    }
}
