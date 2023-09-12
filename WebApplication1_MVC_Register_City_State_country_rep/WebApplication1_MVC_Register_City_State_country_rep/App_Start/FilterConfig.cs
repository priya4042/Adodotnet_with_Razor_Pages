using System.Web;
using System.Web.Mvc;

namespace WebApplication1_MVC_Register_City_State_country_rep
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
