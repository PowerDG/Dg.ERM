using Microsoft.AspNetCore.Mvc;

namespace Dg.ERM.Web.Controllers
{
    public class HomeController : ERMControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}