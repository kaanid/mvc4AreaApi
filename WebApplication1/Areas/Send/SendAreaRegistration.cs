using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication1.Areas.Send
{
    public class SendAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Send";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Send_default",
                "Send/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            GlobalConfiguration.Configuration.Routes.MapHttpRoute("sendapi", "api/"+AreaName+"/{controller}/{id}");
        }
    }
}