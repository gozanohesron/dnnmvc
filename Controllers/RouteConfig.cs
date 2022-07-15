using DotNetNuke.Web.Mvc.Routing;

namespace NetcareIconicPages.NetcareIconicPages.Controllers
{
    public class RouteConfig : IMvcRouteMapper

    {
        public void RegisterRoutes(DotNetNuke.Web.Mvc.Routing.IMapRoute mapRouteManager)
        {

            mapRouteManager.MapRoute(
                "NetcareIconicPages",
                "default", 
                "{controller}/{action}", 
                new[] {"NetcareIconicPages.NetcareIconicPages.Controllers"});
        }

    }
}