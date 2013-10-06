using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppInit.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.PreWarmed = HttpRuntime.Cache["IsPreWarmed"] ?? "NOT Pre-Warmed";
            return View();
        }

        
    }
}
