using System.Web.Http;/*add customized code between this region*/
/*add customized code between this region*/


namespace TestPsm.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );/*add customized code between this region*/
/*add customized code between this region*/

        }
    }
}