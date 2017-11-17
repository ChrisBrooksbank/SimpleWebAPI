using System.Web.Http;
using WebApi.StructureMap;

namespace SimpleWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.UseStructureMap<IOCRegistry>();
        }
    }
}
