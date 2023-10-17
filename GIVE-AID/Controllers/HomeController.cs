using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the home page at {DateTime.Now}");
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}