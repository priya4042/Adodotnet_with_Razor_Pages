using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_Cntr_city_sta
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
