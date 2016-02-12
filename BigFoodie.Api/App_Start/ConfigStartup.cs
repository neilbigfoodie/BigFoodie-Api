using System.Web.Http;
using BigFoodie.Api;
using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(ConfigStartup))]
namespace BigFoodie.Api
{
    public class ConfigStartup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            config.EnableSwagger(c => c.SingleApiVersion("v1", "BigFoodieMealsAPI"))
                .EnableSwaggerUi();

            app.UseNinjectMiddleware(NinjectKernal.CreateKernel).UseNinjectWebApi(config);
        }
    }
}