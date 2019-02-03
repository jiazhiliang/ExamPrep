using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Caching;
using System.Data.SqlClient;

namespace E70487Web.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(SqlDependency = "CommandNotification")]
        public ActionResult Index()
        {
            var cache = HttpContext.Cache;
            var sqlDependency = new SqlCacheDependency(new SqlCommand()
            {

                NotificationAutoEnlist = true

            });

            var d = new SqlDependency();
            d.OnChange += (s, e) =>
            {
                 

            };

            // Will throw exception of httpException
            cache.Add("k1", "v1", sqlDependency,
                DateTime.Now.AddSeconds(10), TimeSpan.FromSeconds(10),
                CacheItemPriority.Default, (k, v, r) =>
                {
                });

            return View();

        }
    }
}