using GIVE_AID.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Controllers
{
    public class NewsController : Controller
    {
        public DataDbContext Context;


        public NewsController(DataDbContext context)
        {
            Context = context;
        }

        public NewsController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index(string searchString, int? page)
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the home page at {DateTime.Now}");
            var news = Context.News.ToList();
            return View(news);
        }
        public ActionResult Details(int id)
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the home page at {DateTime.Now}");
            var news = Context.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }
    }
}