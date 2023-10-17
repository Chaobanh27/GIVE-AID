using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using NLog;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CausesController : Controller
    {
        public DataDbContext Context;
        public CausesController(DataDbContext context)
        {
            Context = context;
        }

        public CausesController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        // GET: Admin/Causes
        public ActionResult Index(string searchString, int? page)
        {
            var causeList = from cause in Context.Causes
                            orderby cause.Id
                            select new CausesListModel
                            {
                                Id = cause.Id,
                                CauseName = cause.CauseName,
                                Status = cause.Status,
                                CreatedDate = cause.CreatedDate,
                            };
            if (!String.IsNullOrEmpty(searchString))
            {
                causeList = causeList.Where(u => u.CauseName.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }

            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePage = causeList.ToPagedList(pageNumber, pageSize);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the user list page at {DateTime.Now}");
            return View(onePage);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cause model)
        {
            if (ModelState.IsValid)
            {
                if (Context.Causes.Any(c => c.CauseName == model.CauseName))
                {
                    ModelState.AddModelError("Username", "Tên đăng nhập đã tồn tại");
                    return View(model);
                }

                var cause = new Cause
                {
                    CauseName = model.CauseName,
                    CreatedDate = DateTime.Now,
                };
                Context.Causes.Add(cause);
                Context.SaveChanges();
                TempData["AlertMessage"] = "Cause Created Successfully";
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
        public ActionResult Edit(int id)
        {
            var cause = Context.Causes.Find(id);
            CausesListModel model = new CausesListModel
            {
                Id = cause.Id,
                CauseName = cause.CauseName,
                Status = cause.Status
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CausesListModel model)
        {
            if (ModelState.IsValid)
            {
                var cause = Context.Causes.Find(model.Id);
                cause.CauseName = model.CauseName;
                cause.Status = model.Status;
                Context.SaveChanges();
                TempData["AlertMessage"] = "Cause Edited Successfully";
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
        public ActionResult Details(int id)
        {
            var cause = Context.Causes.Find(id);
            if (cause == null)
            {
                return HttpNotFound();
            }
            return View(cause);
        }
        public ActionResult Delete(int id)
        {
            var cause = Context.Causes.Find(id);
            if (cause == null)
            {
                return HttpNotFound();
            }
            cause.Status = false;
            TempData["AlertMessage"] = "Cause status has been set inActive";
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}