using System.Web;
using System.Web.Mvc;

namespace Multiple_CheckBox_Save_into_Database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
