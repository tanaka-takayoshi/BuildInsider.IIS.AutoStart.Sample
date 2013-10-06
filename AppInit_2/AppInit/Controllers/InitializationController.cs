using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AppInit.Controllers
{
    public class InitializationController : Controller
    {
        //
        // GET: /Initialization/

        public ActionResult Index()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return View();
        }

    }
}
