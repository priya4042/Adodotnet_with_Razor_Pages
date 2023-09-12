using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_Register_City_Country_State
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
