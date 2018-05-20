using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html5Demo.Controllers
{
    public class Html5Controller : Controller
    {
        // GET: Html5
        public ActionResult BrowserSupport()
        {
            return View();
        }
    }
}