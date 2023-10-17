using System;
using System.Collections.Generic;
using PagedList;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.ObjectModel;
using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using NLog;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersListController : Controller
    {
        public DataDbContext Context;


        public UsersListController(DataDbContext context)
        {
            Context = context;
        }

        public UsersListController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index(string searchString, int? page)
        {
            var userList = from user in Context.Users
                           join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                           join urm in Context.UsersRolesMappings on user.Id equals urm.UserId
                           join role in Context.Roles on urm.RoleId equals role.Id
                           orderby user.Id
                           select new UserListModel
                           {
                               Id = user.Id,
                               Avatar = user.Avatar,
                               Username = user.Username,
                               Password = user.Password,
                               FullName = userDetail.FullName,
                               Gender = userDetail.Gender,
                               DateOfBirth = userDetail.DateOfBirth,
                               Phone = userDetail.Phone,
                               Email = user.Email,
                               Address = userDetail.Address,
                               CreatedDate = userDetail.CreatedDate,
                               RoleName = role.RoleName,
                               Status = user.Status
                           };
            if (!String.IsNullOrEmpty(searchString))
            {
                userList = userList.Where(u => u.Username.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }

            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePageUsers = userList.ToPagedList(pageNumber, pageSize);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the user list page at {DateTime.Now}");
            return View(onePageUsers);
        }
        public ActionResult Create()
        {
            var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
            var roles = Context.Roles.ToList();
            var model = new UserListModel
            {
                GenderList = genders,
                RolesList = roles,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserListModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem người dùng đã tồn tại chưa
                if (Context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("Username", "Tên đăng nhập đã tồn tại");
                    return View(model);
                }

                var user = new User
                {
                    Avatar = model.Avatar,
                    Username = model.Username,
                    Password = model.Password,
                    Email = model.Email,
                };
                Context.Users.Add(user);
                Context.SaveChanges();
                var userDetail = new UserDetail
                {
                    Id = user.Id,
                    FullName = model.FullName,
                    Gender = model.Gender,
                    DateOfBirth = model.DateOfBirth,
                    Phone = model.Phone,
                    Address = model.Address,
                    CreatedDate = DateTime.Now,
                };
                Context.UserDetails.Add(userDetail);
                Context.SaveChanges();
                var userRoleMapping = new UsersRolesMapping
                {
                    UserId = user.Id,
                    RoleId = model.RoleId,
                };
                Context.UsersRolesMappings.Add(userRoleMapping);
                Context.SaveChanges();
                TempData["AlertMessage"] = "User Created Successfully";
                return RedirectToAction("Index");
            }
            //sử dụng vòng lặp for để lặp qua các phần tử của ModelState.Values.
            //để lặp qua các phần tử một cách thủ công và không bị ảnh hưởng bởi việc thêm, xoá hoặc sửa đổi các phần tử trong collection đó.
            for (int i = 0; i < ModelState.Values.Count; i++)
            {
                var errors = ModelState.Values.ElementAt(i).Errors;
                if (errors.Count > 0)
                {
                    // Thêm thông tin lỗi vào model state của request hiện tại
                    ModelState.AddModelError(string.Empty, errors[0].ErrorMessage);
                }
            }
            var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
            model.GenderList = genders;
            var roles = Context.Roles.ToList();
            model.RolesList = roles;
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var u = Context.Users.Find(id);
            var userList = from user in Context.Users
                           join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                           join urm in Context.UsersRolesMappings on user.Id equals urm.UserId
                           join role in Context.Roles on urm.RoleId equals role.Id
                           where user.Id == u.Id
                           select new UserListModel
                           {
                               Id = user.Id,
                               Username = user.Username,
                               Password = user.Password,
                               Avatar = user.Avatar,
                               FullName = userDetail.FullName,
                               Gender = userDetail.Gender,
                               DateOfBirth = userDetail.DateOfBirth,
                               Phone = userDetail.Phone,
                               Email = user.Email,
                               Address = userDetail.Address,
                               CreatedDate = userDetail.CreatedDate,
                               RoleName = role.RoleName,
                           };
            return View(userList.FirstOrDefault());
        }
        public ActionResult Edit(int id)
        {
            var user = Context.Users.Find(id);
            var userDetail = Context.UserDetails.Find(id);
            var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
            var roles = Context.Roles.ToList();
            UserListModel model = new UserListModel
            {
                Id = user.Id,
                Avatar = user.Avatar,
                Username = user.Username,
                Password = user.Password,
                FullName = userDetail.FullName,
                Gender = userDetail.Gender,
                DateOfBirth = userDetail.DateOfBirth,
                Phone = userDetail.Phone,
                Email = user.Email,
                Address = userDetail.Address,
                CreatedDate = userDetail.CreatedDate,
                RoleId = user.UsersRolesMappings.FirstOrDefault().RoleId,
                RolesList = roles,
                GenderList = genders,
                Status = user.Status
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(UserListModel model)
        {
            if (ModelState.IsValid)
            {

                var user = Context.Users.Find(model.Id);
                user.Avatar = model.Avatar;
                user.Username = model.Username;
                user.Email = model.Email;
                user.Status = model.Status;
                var userSession = (UserSession)System.Web.HttpContext.Current.Session["USER_SESSION"];
                userSession.UserName = model.Username;
                userSession.Avatar = model.Avatar;
                if (model.Password != user.Password)                           //nếu như password không thay đổi thì giữ nguyên còn không thì mã hóa
                {
                    user.Password = model.Password;
                }
                var userDetail = Context.UserDetails.Find(model.Id);
                userDetail.FullName = model.FullName;
                userDetail.Gender = model.Gender;
                userDetail.DateOfBirth = model.DateOfBirth;
                userDetail.Phone = model.Phone;
                userDetail.Address = model.Address;
                userDetail.CreatedDate = model.CreatedDate;
                var usersRolesMapping = Context.UsersRolesMappings.Find(model.Id);
                usersRolesMapping.RoleId = model.RoleId;
                usersRolesMapping.UserId = model.Id;
                Context.SaveChanges();
                TempData["AlertMessage"] = "User Edited Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                //sử dụng vòng lặp for để lặp qua các phần tử của ModelState.Values.
                //để lặp qua các phần tử một cách thủ công và không bị ảnh hưởng bởi việc thêm, xoá hoặc sửa đổi các phần tử trong collection đó.
                for (int i = 0; i < ModelState.Values.Count; i++)
                {
                    var errors = ModelState.Values.ElementAt(i).Errors;
                    if (errors.Count > 0)
                    {
                        // Thêm thông tin lỗi vào model state của request hiện tại
                        ModelState.AddModelError(string.Empty, errors[0].ErrorMessage);
                    }
                }
                var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
                model.GenderList = genders;
                var roles = Context.Roles.ToList();
                model.RolesList = roles;
                // Trả về view với thông tin lỗi
                return View(model);
            }

        }
        public ActionResult Delete(int id)
        {
            var user = Context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            user.Status = false;
            TempData["AlertMessage"] = "User status has been set inActive";
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}