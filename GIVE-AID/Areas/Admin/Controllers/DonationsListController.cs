using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using NLog;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Areas.Admin.Controllers
{
    public class DonationsListController : Controller
    {
        public DataDbContext Context;


        public DonationsListController(DataDbContext context)
        {
            Context = context;
        }

        public DonationsListController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index(string searchString, int? page)
        {
            var donationList = from user in Context.Users
                           join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                           join donation in Context.Donations on user.Id equals donation.UserId
                           join cause in Context.Causes on donation.CauseId equals cause.Id
                           orderby donation.Id
                           select new DonationsListModel
                           {
                               Id = donation.Id,
                               Amount = donation.Amount,
                               DonationDate = donation.DonationDate,
                               UserId = donation.UserId,
                               Username = user.Username,
                               CauseId = donation.CauseId,
                               CauseName = cause.CauseName
                           };
            if (!String.IsNullOrEmpty(searchString))
            {
                donationList = donationList.Where(d => d.CauseName.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }

            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePageUsers = donationList.ToPagedList(pageNumber, pageSize);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the donation list page at {DateTime.Now}");
            return View(onePageUsers);
        }

        public ActionResult Details(int id)
        {
            var d = Context.Donations.Find(id);
            var donationsList = from user in Context.Users
                                join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                                join donation in Context.Donations on user.Id equals donation.UserId
                                join cause in Context.Causes on donation.CauseId equals cause.Id
                                where donation.Id == d.Id
                           select new DonationsListModel
                           {
                               Id = donation.Id,
                               Amount = donation.Amount,
                               DonationDate = donation.DonationDate,
                               UserId = donation.UserId,
                               Username = user.Username,
                               CauseId = donation.CauseId,
                               CauseName = cause.CauseName
                           };
            return View(donationsList.FirstOrDefault());
        }
    }
}