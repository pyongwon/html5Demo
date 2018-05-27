using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html5Demo.Controllers
{
    public class ApiController : Controller
    {
        // GET: Geolocation
        public ActionResult Geolocation()
        {
            return View();
        }

        // GET: Canvas
        public ActionResult Canvas()
        {
            return View();
        }

        // GET: Canvas
        public ActionResult CanvasAdvanced()
        {
            return View();
        }

        // GET: Video
        public ActionResult Video()
        {
            return View();
        }

        // GET: WebStorage
        public ActionResult WebStorage()
        {
            return View();
        }

        // GET: DragAndDrop
        public ActionResult DragAndDrop()
        {
            return View();
        }
    }
}