using System.Web;
using System.Web.Mvc;

namespace chrisandlenka2.co.uk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
