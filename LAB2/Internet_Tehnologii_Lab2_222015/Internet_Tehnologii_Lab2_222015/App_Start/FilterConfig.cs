using System.Web;
using System.Web.Mvc;

namespace Internet_Tehnologii_Lab2_222015
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
