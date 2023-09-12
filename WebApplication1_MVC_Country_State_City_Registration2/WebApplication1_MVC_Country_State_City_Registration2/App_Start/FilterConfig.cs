using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_Country_State_City_Registration2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
