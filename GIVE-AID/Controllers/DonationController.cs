using GIVE_AID.Models;
using NLog;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Controllers
{
    public class DonationController : Controller
    {
        //Hàm dựng khởi tạo.Khi vào controller sẽ khởi tạo kết nối đến database
        public DataDbContext Context;


        public DonationController(DataDbContext context)
        {
            Context = context;
        }

        public DonationController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = NLog.LogManager.GetCurrentClassLogger();
        [Authorize(Roles = "Admin,User")]
        public ActionResult Create()
        {
            var causes = Context.Causes.ToList();
            ViewBag.Causes = causes.Where(n => n.Status == true);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the donation page at {DateTime.Now}");
            return View();
        }

        [Authorize(Roles = "Admin,User")]
        [HttpPost]
        public ActionResult Create(string stripeToken, string stripeEmail, FormCollection form, Donation model)
        {
            var user = System.Web.HttpContext.Current.Session["USER_SESSION"];

            var donation = new Donation
            {
                UserId = model.UserId,
                CauseId = model.CauseId,
                Amount = model.Amount,
                DonationDate = DateTime.Now
            };

            Context.Donations.Add(donation);
            Context.SaveChanges();

            StripeConfiguration.ApiKey = System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
            var options = new ChargeCreateOptions
            {
                Amount = (long?)model.Amount,
                Currency = "usd",
                Description = "Example Charge",
                Source = "tok_visa",
                ReceiptEmail = stripeEmail
            };

            var service = new ChargeService();
            Charge charge = service.Create(options);

            if (charge.Status == "succeeded")
            {
                return RedirectToAction("PaymentSuccess");
            }
            else
            {
                return RedirectToAction("PaymentFailure");
            }
        }

        public ActionResult PaymentSuccess()
        {
            return View();
        }

        public ActionResult PaymentFailure()
        {
            return View();
        }
    }
}