﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeAdminController : Controller
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the Admin home page at {DateTime.Now}");
            return View();
        }
    }
}