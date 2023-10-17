using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class NewsListController : Controller
    {
        public DataDbContext Context;


        public NewsListController(DataDbContext context)
        {
            Context = context;
        }

        public NewsListController() : this(new DataDbContext())
        {
        }
        public ActionResult Index(string searchString, int? page)
        {
            var newsList = from user in Context.Users
                           join news in Context.News on user.Id equals news.UserId
                           orderby news.Id
                           select new NewsListModel
                           {
                               Id = news.Id,
                               Title = news.Title,
                               Description = news.Description,
                               ImagePath = news.ImagePath,
                               Content = news.Content,
                               Author = news.Author,
                               TypeOfNews = news.TypeOfNews,
                               CreatedDate = news.CreatedDate,
                               ModifiedDate = news.ModifiedDate,
                               Status = news.Status,
                               UserId = user.Id,
                           };
            if (!String.IsNullOrEmpty(searchString))
            {
                newsList = newsList.Where(n => n.Title.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePageUsers = newsList.ToPagedList(pageNumber, pageSize);
            return View(onePageUsers);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(NewsListModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem tiêu đề đã tồn tại chưa
                if (Context.News.Any(u => u.Title == model.Title))
                {
                    ModelState.AddModelError("Title", "Tiêu đề đã tồn tại");
                    return View(model);
                }
                // Lấy thông tin người dùng hiện tại
                var currentUser = System.Web.HttpContext.Current.User;
                // Lấy UserId của người dùng hiện tại
                var currentUserId = Context.Users.SingleOrDefault(u => u.Username == currentUser.Identity.Name).Id;
                var news = new News
                {
                    Title = model.Title,
                    Description = model.Description,
                    ImagePath = model.ImagePath,
                    Content = model.Content,
                    Author = model.Author,
                    TypeOfNews = model.TypeOfNews,
                    CreatedDate = model.CreatedDate,
                    ModifiedDate = model.ModifiedDate,
                    Status = model.Status,
                    UserId = currentUserId,
                };
                Context.News.Add(news);
                Context.SaveChanges();
                TempData["AlertMessage"] = "News Created Successfully";
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
            var news = Context.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }
        public ActionResult Edit(int id)
        {
            var news = Context.News.Find(id);
            return View(news);
        }
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NewsListModel model)
        {
            if (ModelState.IsValid)
            {
                var news = Context.News.Find(model.Id);
                news.Title = model.Title;
                news.Description = model.Description;
                news.ImagePath = model.ImagePath;
                news.Content = model.Content;
                news.Author = model.Author;
                news.TypeOfNews = model.TypeOfNews;
                news.ModifiedDate = model.ModifiedDate;
                news.Status = model.Status;
                news.UserId = model.UserId;
                Context.SaveChanges();
                TempData["AlertMessage"] = "News Edited Successfully";
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
            var news = Context.News.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            news.Status = false;
            TempData["AlertMessage"] = "User Deleted Successfully";
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}