using System.Web;
using System.Web.Mvc;

namespace MVC5Court_work_1030
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
