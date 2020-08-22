using System.Web;
using System.Web.Mvc;

namespace Ftec.ProjetosWeb.Aplicativo1.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
