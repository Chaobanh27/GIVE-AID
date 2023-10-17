using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using NLog;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class NGOsListController : Controller
    {
        public DataDbContext Context;


        public NGOsListController(DataDbContext context)
        {
            Context = context;
        }

        public NGOsListController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        // GET: Admin/NGOsList
        public ActionResult Index(string searchString, int? page)
        {
            var NGOsList = from ngo in Context.NGOs
                           orderby ngo.Id
                           select new NGOsListModel
                           {
                               Id = ngo.Id,
                               Name = ngo.Name,
                               Address = ngo.Address,
                               City = ngo.City,
                               Country = ngo.Country,
                               Email = ngo.Email,
                               Phone = ngo.Phone,
                               Status = ngo.Status
                           };
            if (!String.IsNullOrEmpty(searchString))
            {
                NGOsList = NGOsList.Where(n => n.Name.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePageUsers = NGOsList.ToPagedList(pageNumber, pageSize);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the NGO'S list page at {DateTime.Now}");
            return View(onePageUsers);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(NGO model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem tiêu đề đã tồn tại chưa
                if (Context.NGOs.Any(u => u.Name == model.Name))
                {
                    ModelState.AddModelError("Title", "Tiêu đề đã tồn tại");
                    return View(model);
                }
                // Lấy thông tin người dùng hiện tại
                var currentUser = System.Web.HttpContext.Current.User;
                // Lấy UserId của người dùng hiện tại
                var currentUserId = Context.Users.SingleOrDefault(u => u.Username == currentUser.Identity.Name).Id;
                var ngo = new NGO
                {
                    Name = model.Name,
                    Address = model.Address,
                    City = model.City,
                    Country = model.Country,
                    Email = model.Email,
                    Phone = model.Phone,
                    UserId = currentUserId,
                    CreatedDate = DateTime.Now,
                };
                Context.NGOs.Add(ngo);
                Context.SaveChanges();
                TempData["AlertMessage"] = "NGO's Created Successfully";
                return RedirectToAction("Index");
            }
            for (int i = 0; i < ModelState.Values.Count; i++)
            {
                var errors = ModelState.Values.ElementAt(i).Errors;
                if (errors.Count > 0)
                {
                    ModelState.AddModelError(string.Empty, errors[0].ErrorMessage);
                }
            }
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var news = Context.NGOs.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        public ActionResult Edit(int id)
        {
            var ngo = Context.NGOs.Find(id);
            NGOsListModel model = new NGOsListModel
            {
                Id = ngo.Id,
                Name = ngo.Name,
                Address = ngo.Address,
                City = ngo.City,
                Country = ngo.Country,
                Email = ngo.Email,
                Phone = ngo.Phone,
                Status = ngo.Status,
                UserId = ngo.UserId,
        };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NGOsListModel model)
        {
            if (ModelState.IsValid)
            {
                var ngo = Context.NGOs.Find(model.Id);
                ngo.Name = model.Name;
                ngo.Address = model.Address;
                ngo.City = model.City;
                ngo.Country = model.Country;
                ngo.Email = model.Email;
                ngo.Phone = model.Phone;
                ngo.Status = model.Status;
                ngo.UserId = model.UserId;
                Context.SaveChanges();
                TempData["AlertMessage"] = "NGO's Edited Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                for (int i = 0; i < ModelState.Values.Count; i++)
                {
                    var errors = ModelState.Values.ElementAt(i).Errors;
                    if (errors.Count > 0)
                    {
                        ModelState.AddModelError(string.Empty, errors[0].ErrorMessage);
                    }
                }
                return View(model);
            }

        }
        public ActionResult Delete(int id)
        {
            var ngos = Context.NGOs.Find(id);
            if (ngos == null)
            {
                return HttpNotFound();
            }
            ngos.Status = false;
            TempData["AlertMessage"] = "NGO's status has been set inActive";
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}