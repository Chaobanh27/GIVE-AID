using GIVE_AID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GIVE_AID.Controllers
{
    public class AccountsController : Controller
    {
        public DataDbContext Context;


        public AccountsController(DataDbContext context)
        {
            Context = context;
        }

        public AccountsController() : this(new DataDbContext())
        {
        }
        private static readonly ILogger logger = NLog.LogManager.GetCurrentClassLogger();
        public ActionResult Login()
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the Login page at {DateTime.Now}");
            if (Request.Cookies["RememberMe"] != null)                                     //kiểm tra xem cookie Remember Me đã tồn tại hay chưa và sau đó đặt giá trị của các trường đăng nhập tương ứng nếu nó tồn tại.
            {
                HttpCookie authCookie = Request.Cookies["RememberMe"];
                string userName = authCookie.Values["Username"];
                string password = authCookie.Values["Password"];
                bool rememberMe = true;

                // đăng nhập với thông tin đăng nhập lưu trong cookie
                var model = new LoginModel { Username = userName, Password = password, RememberMe = rememberMe };
                return View(model);
            }
            return View();
        }

        //Hàm đăng nhập
        [HttpPost]
        [ValidateAntiForgeryToken]                                                       //ValidateAntiForgeryToken để sinh ra mã Token để khi chạy nó sẽ so sánh 2 phía client và server có trùng lặp tránh trường hợp không khớp và request liên tục và tránh các cuộc tấn công Cross-Site Request Forgery (CSRF)
        public ActionResult Login(LoginModel model)
        {

            if (ModelState.IsValid)  //Kiểm tra tính hợp lệ của dữ liệu
            {
                bool isAuthenticated = AuthenticateUser(model.Username, model.Password);
                if (isAuthenticated)                                                                        //Nếu người dùng được xác thực thành công, phương thức sẽ đặt cookie xác thực bằng cách sử dụng FormsAuthentication.SetAuthCookie, thêm thông tin người dùng vào Session bằng cách sử dụng Session.Add
                {
                    logger.Info($"User {model.Username} logged in at {DateTime.Now}.");
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    var user = Context.Users.FirstOrDefault(u => u.Username == model.Username);             // truy vấn bảng "Users" trong cơ sở dữ liệu thông qua đối tượng "Context" (khai báo trước đó trong code của ứng dụng) để tìm một bản ghi đầu tiên trong bảng "Users" mà có tên đăng nhập bằng với tên đăng nhập được truyền vào thông qua biến "model.Username". Nếu tìm thấy bản ghi thỏa mãn, nó sẽ được gán vào biến "user". Nếu không tìm thấy bản ghi thỏa mãn, biến "user" sẽ bị gán giá trị "null"
                    var userSession = new UserSession();
                    userSession.Id = user.Id;
                    userSession.UserName = model.Username;
                    userSession.Avatar = user.Avatar;
                    Session.Add("USER_SESSION", userSession);
                    if (model.RememberMe)                                                                    //HttpCookie để tạo một cookie có tên "RememberMe" và đặt giá trị của cookie là tên đăng nhập và mật khẩu của người dùng. Chúng ta đặt thời hạn lưu trữ của cookie là 7 ngày và sau đó thêm cookie vào Response để gửi về cho trình duyệt.
                    {
                        HttpCookie authCookie = new HttpCookie("RememberMe");
                        authCookie.Values["Username"] = model.Username;
                        authCookie.Values["Password"] = model.Password;
                        authCookie.Expires = DateTime.Now.AddDays(7);
                        Response.Cookies.Add(authCookie);
                    }
                    if (Roles.IsUserInRole(model.Username, "Admin"))
                    {
                        return RedirectToAction("HomeAdmin", "Admin");
                    }
                    else if (Roles.IsUserInRole(model.Username, "User"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            return View(model);
        }

        //hàm kiểm tra xác nhận người dùng
        public bool AuthenticateUser(string username, string password)
        {
            var status = false;
            var user = Context.Users.FirstOrDefault(u => u.Username == username);            //FirstorDefault trả về phần tử đầu tiên của collection theo điều kiện còn không thì trả về giá trị mặc định 
            if (user != null)                                                                //nếu như username không để trống thì xét tiết mật khẩu
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password) && user.Status == true)
                {
                    status = true;
                }
            }
            return status;
        }

        //Hàm đăng xuất
        public ActionResult Logout()
        {
            string username = HttpContext.User.Identity.Name;
            string ipAddress = Request.UserHostAddress;
            logger.Info($"User {username} logged out at {DateTime.Now}.");
            FormsAuthentication.SignOut();
            //if (Request.Cookies["RememberMe"] != null)                                        //sử dụng Request.Cookies để kiểm tra xem cookie Remember Me đã tồn tại hay chưa. Nếu nó tồn tại, chúng ta sẽ tạo một HttpCookie mới với thời hạn lưu trữ 0 để xóa cookie và sau đó thêm cookie mới này vào Response để gửi về cho trình duyệt
            //{
            //    HttpCookie authCookie = Request.Cookies["RememberMe"];
            //    authCookie.Expires = DateTime.Now.AddDays(-1);
            //    Response.Cookies.Add(authCookie);
            //}
            Session.Remove("USER_SESSION");
            return RedirectToAction("Login", "Accounts");
        }

        public ActionResult Register()
        {
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} visited the register page at {DateTime.Now}");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem người dùng đã tồn tại chưa
                if (Context.Users.Any(u => u.Username == model.Username))
                {
                    ModelState.AddModelError("Username", "Tên đăng nhập đã tồn tại");
                    return View(model);
                }
                var defaultAvatar = "/Uploads/images/user.png";
                var user = new User
                {
                    Username = model.Username,
                    Password = Hashing.HashPassword(model.Password),
                    Avatar = defaultAvatar,
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
                    CreatedDate = model.CreatedDate,
                };
                Context.UserDetails.Add(userDetail);
                Context.SaveChanges();
                var defaultRole = Context.Roles.FirstOrDefault(r => r.RoleName == "User");
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
                return RedirectToAction("Login", "Accounts");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult SendInvitation(string emailAddress)
        {
            if (!ModelState.IsValid)
            {
                return View("InviteError");
            }
            var subject = "Mời tham gia hoạt động"; ;
            var body = "Xin chào, bạn được mời tham gia hoạt động.";
            EmailService.SendMail(emailAddress, subject, body);
            string username = HttpContext.User.Identity.Name;
            logger.Info($"User {username} send an email at {DateTime.Now}.");
            return RedirectToAction("InviteSuccess");
        }
        public ActionResult InviteSuccess()
        {
            return View();
        }
        public ActionResult InviteError()
        {
            return View();
        }
    }
}