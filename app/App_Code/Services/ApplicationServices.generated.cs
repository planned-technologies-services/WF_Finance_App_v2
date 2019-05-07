using MyCompany.Handlers;
using MyCompany.Web;
using System.Web.Configuration;

namespace MyCompany.Services
{
	public class AppFrameworkConfig
    {
        
        public virtual void Initialize()
        {
            ApplicationServices.FrameworkAppName = "WF Finance App v2";
            ApplicationServices.FrameworkSiteContentControllerName = "SiteContent";
            ApplicationServices.Version = "8.7.10.7";
            ApplicationServices.JqmVersion = "1.4.6";
            ApplicationServices.HostVersion = "1.2.5.0";
            var compilation = ((CompilationSection)(WebConfigurationManager.GetSection("system.web/compilation")));
            var releaseMode = !compilation.Debug;
            AquariumExtenderBase.EnableMinifiedScript = releaseMode;
            AquariumExtenderBase.EnableCombinedScript = releaseMode;
            ApplicationServices.EnableMinifiedCss = releaseMode;
            ApplicationServices.EnableCombinedCss = releaseMode;
            ApplicationServicesBase.AuthorizationIsSupported = false;
            BlobFactoryConfig.Initialize();
        }
    }
}
