using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_City_Country_state_register4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
