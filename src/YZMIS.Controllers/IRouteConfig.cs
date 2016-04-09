using System.Web.Routing;

namespace YZMIS.Controllers
{
    public interface IRouteConfig
    {
        void RegisterRoutes(RouteCollection routes);
    }
}
