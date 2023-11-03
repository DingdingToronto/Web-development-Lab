using System.Web;
using System.Web.Mvc;

namespace C__Assignment2_JiabaoDing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
