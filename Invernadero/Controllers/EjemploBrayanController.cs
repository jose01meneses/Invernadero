using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invernadero.Controllers
{
    public class EjemploBrayanController : Controller
    {
        // GET: EjemploBrayan
        public ActionResult Index()
        {
            return View(Index);
        }
    }
}