using System.Web;
using System.Web.Mvc;

namespace WebApplication1_Mvc_Upsert_Save
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
