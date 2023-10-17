using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using PagedList;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminsListController : Controller
    {
        public DataDbContext Context;


        public AdminsListController(DataDbContext context)
        {
            Context = context;
        }

        public AdminsListController() : this(new DataDbContext())
        {
        }
        // GET: Admin/AdminsList
        public ActionResult Index(string searchString, int? page)
        {
            var teachersList = from user in Context.Users
                               join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                               join userRoleMapping in Context.UsersRolesMappings on user.Id equals userRoleMapping.UserId
                               join role in Context.Roles on userRoleMapping.RoleId equals role.Id
                               orderby user.Id
                               where role.RoleName == "Admin"
                               select new UserListModel
                               {
                                   Id = user.Id,
                                   Username = user.Username,
                                   Password = user.Password,
                                   Avatar = user.Avatar,
                                   Email = user.Email,
                                   FullName = userDetail.FullName,
                                   Gender = userDetail.Gender,
                                   DateOfBirth = userDetail.DateOfBirth,
                                   Phone = userDetail.Phone,
                                   Address = userDetail.Address,
                                   CreatedDate = userDetail.CreatedDate,
                                   RoleName = role.RoleName,
                                   Status = user.Status
                               };
            if (!String.IsNullOrEmpty(searchString))
            {
                teachersList = teachersList.Where(u => u.Username.Contains(searchString));
                ViewBag.currentFilter = searchString;
            }
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            var onePageUsers = teachersList.ToPagedList(pageNumber, pageSize);
            return View(onePageUsers);
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
                               Email = user.Email,
                               FullName = userDetail.FullName,
                               Gender = userDetail.Gender,
                               DateOfBirth = userDetail.DateOfBirth,
                               Phone = userDetail.Phone,
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
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                FullName = userDetail.FullName,
                Gender = userDetail.Gender,
                DateOfBirth = userDetail.DateOfBirth,
                Phone = userDetail.Phone,
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
        [ValidateAntiForgeryToken]
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
                if (model.Password != user.Password)
                {
                    user.Password = Hashing.HashPassword(model.Password);
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
                TempData["AlertMessage"] = "User Edit Successfully";
                Context.SaveChanges();
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
                var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
                model.GenderList = genders;
                var roles = Context.Roles.ToList();
                model.RolesList = roles;
                return View(model);
            }

        }

        public ActionResult Create()
        {
            var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
            var model = new UserListModel
            {
                GenderList = genders,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserListModel model)
        {
            if (ModelState.IsValid)
            {
                if (Context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("Username", "Tên đăng nhập đã tồn tại");
                    return View(model);
                }

                var user = new User
                {
                    Avatar = model.Avatar,
                    Username = model.Username,
                    Email = model.Email,
                    Password = Hashing.HashPassword(model.Password)
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
                    CreatedDate = model.CreatedDate,
                };
                Context.UserDetails.Add(userDetail);
                Context.SaveChanges();
                var defaultRole = Context.Roles.FirstOrDefault(r => r.RoleName == "Admin");
                if (defaultRole != null)
                {
                    var userRoleMapping = new UsersRolesMapping
                    {
                        UserId = user.Id,
                        RoleId = defaultRole.Id
                    };

                    Context.UsersRolesMappings.Add(userRoleMapping);
                    Context.SaveChanges();
                }
                TempData["AlertMessage"] = "User Created Successfully";
                return RedirectToAction("Index");
            }
            var genders = Context.UserDetails.Select(u => u.Gender).Distinct().ToList();
            model.GenderList = genders;
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var user = Context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            user.Status = false;
            TempData["AlertMessage"] = "User Deleted Successfully";
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}