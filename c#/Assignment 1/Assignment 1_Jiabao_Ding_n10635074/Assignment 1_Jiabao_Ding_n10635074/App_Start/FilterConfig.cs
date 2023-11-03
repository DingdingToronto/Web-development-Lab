using System.Web;
using System.Web.Mvc;

namespace Assignment_1_Jiabao_Ding_n10635074
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
