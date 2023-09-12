using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC__ctry_cpuny
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
