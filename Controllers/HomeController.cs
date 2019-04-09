using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMARC_WebAPI.Models;

namespace TMARC_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "TMARC Rewards";
            Session["currentWindow"] = 0;
            return View();
        }

        [HttpPost]
        public ActionResult Locate(ObjIpLookup objLocation)
        {
            objLocation.CaptureTime = DateTime.Now;

            Session["currentLoc"] = objLocation;

            return Json(new { success = true });
        }

        #region 1. Registration

        [HttpPost]
        public ActionResult Registration()
        {

            return Json(new { success = true });
        }

        #endregion

        #region 2. Opt in

        [HttpPost]
        public ActionResult OptIn()
        {

            return Json(new { success = true });
        }

        #endregion

        #region 3. First Name

        [HttpPost]
        public ActionResult FirstName()
        {

            return Json(new { success = true });
        }

        #endregion

        #region 4. Profiling 

        [HttpPost]
        public ActionResult Profiling()
        {

            return Json(new { success = true });
        }

        #endregion

        #region 5. Rewarding 

        public ActionResult Rewarding()
        {

            return View();
        }

        #endregion

        #region 6. End

        public ActionResult Thanks()
        {

            return View();
        }

        #endregion





    }
}
