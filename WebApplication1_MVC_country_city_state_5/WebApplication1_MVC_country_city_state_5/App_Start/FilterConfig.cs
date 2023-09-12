using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_country_city_state_5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
