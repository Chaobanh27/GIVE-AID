using GIVE_AID.Areas.Admin.Models;
using GIVE_AID.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GIVE_AID.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MyProfileController : Controller
    {
        public DataDbContext Context;


        public MyProfileController(DataDbContext context)
        {
            Context = context;
        }

        public MyProfileController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            
            var username = User.Identity.Name;
            logger.Info($"User {username} visited the profile page at {DateTime.Now}");
            var query = from user in Context.Users
                        join userDetail in Context.UserDetails on user.Id equals userDetail.Id
                        join urm in Context.UsersRolesMappings on user.Id equals urm.UserId
                        join role in Context.Roles on urm.RoleId equals role.Id
                        where user.Username == username
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
            var myProfile = query.FirstOrDefault();
            return View(myProfile);
        }
    }
}