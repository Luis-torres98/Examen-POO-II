using System.Web;
using System.Web.Mvc;

namespace POOII_CL1_RAMIREZ_MORANTE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
