namespace GIVE_AID.Migrations
{
    using GIVE_AID.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GIVE_AID.Models.DataDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GIVE_AID.Models.DataDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //var user1 = new User
            //{
            //    Username = "admin",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "chaobanhnguyen@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Nguyen Chanh Bao",
            //        Gender = "Male",
            //        DateOfBirth = new DateTime(1996, 06, 27, 00, 00, 00),
            //        Phone = "0917823999",
            //        Address = "123 Black St",
            //        CreatedDate = DateTime.Now,
            //    },

            //};

            //var user2 = new User
            //{
            //    Username = "admin1",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "JohnDoe@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "John Doe",
            //        Gender = "Male",
            //        DateOfBirth = new DateTime(1985, 01, 01, 00, 00, 00),
            //        Phone = "1111111111",
            //        Address = "456 Red St",
            //        CreatedDate = DateTime.Now,
            //    }
            //};

            //var user3 = new User
            //{
            //    Username = "user",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "JaneDoe@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Jane Doe",
            //        Gender = "Female",
            //        DateOfBirth = new DateTime(1990, 03, 05, 00, 00, 00),
            //        Phone = "2222222222",
            //        Address = "789 Rose St",
            //        CreatedDate = DateTime.Now
            //    }
            //};
            //var user4 = new User
            //{
            //    Username = "user1",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "BobSmith@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Bob Smith",
            //        Gender = "Male",
            //        DateOfBirth = new DateTime(1985, 12, 25, 00, 00, 00),
            //        Phone = "3333333333",
            //        Address = "321 Yellow St",
            //        CreatedDate = DateTime.Now,
            //    }
            //};
            //var user5 = new User
            //{
            //    Username = "user2",
            //    Password = "1$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "AliceJohnson@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Alice Johnson",
            //        Gender = "Female",
            //        DateOfBirth = new DateTime(1999, 08, 15, 00, 00, 00),
            //        Phone = "4444444444",
            //        Address = "645 Pink St",
            //        CreatedDate = DateTime.Now
            //    }
            //};
            //var user6 = new User
            //{
            //    Username = "user3",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "TomBrown@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Tom Brown",
            //        Gender = "Male",
            //        DateOfBirth = new DateTime(1978, 03, 10, 00, 00, 00),
            //        Phone = "5555555555",
            //        Address = "978 Green St",
            //        CreatedDate = DateTime.Now,
            //    }
            //};
            //var user7 = new User
            //{
            //    Username = "user4",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "SaraLee@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Sara Lee",
            //        Gender = "Female",
            //        DateOfBirth = new DateTime(1992, 11, 20, 00, 00, 00),
            //        Phone = "8888888888",
            //        Address = "591 Grey St",
            //        CreatedDate = DateTime.Now
            //    }
            //};
            //var user8 = new User
            //{
            //    Username = "user5",
            //    Password = "$2a$12$qAdbFjO7UQ7munU2764F7.7sfGpNRAucQfXI6IU7rNcAn52r.MWdC",
            //    Avatar = "/Uploads/images/boy.png",
            //    Email = "MikeThomas@gmail.com",
            //    UserDetail = new UserDetail
            //    {
            //        FullName = "Mike Thomas",
            //        Gender = "Female",
            //        DateOfBirth = new DateTime(1990, 06, 30, 00, 00, 00),
            //        Phone = "9999999999",
            //        Address = "123 Black St",
            //        CreatedDate = DateTime.Now
            //    }
            //};
            //context.Users.AddOrUpdate(u => new { u.Username, u.Password, u.Avatar, u.Email }, user1, user2, user3, user4, user5, user6, user7, user8);

            //var role1 = new Role { RoleName = "Admin" };
            //var role2 = new Role { RoleName = "User" };
            //context.Roles.AddOrUpdate(r => r.RoleName, role1, role2);

            //var mapping1 = new UsersRolesMapping { UserId = 1, RoleId = 1 };
            //var mapping2 = new UsersRolesMapping { UserId = 2, RoleId = 1 };
            //var mapping3 = new UsersRolesMapping { UserId = 3, RoleId = 2 };
            //var mapping4 = new UsersRolesMapping { UserId = 4, RoleId = 2 };
            //var mapping5 = new UsersRolesMapping { UserId = 5, RoleId = 2 };
            //var mapping6 = new UsersRolesMapping { UserId = 6, RoleId = 2 };
            //var mapping7 = new UsersRolesMapping { UserId = 7, RoleId = 2 };
            //var mapping8 = new UsersRolesMapping { UserId = 8, RoleId = 2 };


            //context.UsersRolesMappings.AddOrUpdate(ur => new { ur.UserId, ur.RoleId }, mapping1, mapping2, mapping3, mapping4, mapping5, mapping6, mapping7, mapping8);



            //var cause1 = new Cause
            //{
            //    CauseName = "Children",
            //    CreatedDate = DateTime.Now
            //};

            //var cause2 = new Cause
            //{
            //    CauseName = "Disabled",
            //    CreatedDate = DateTime.Now
            //};

            //var cause3 = new Cause
            //{
            //    CauseName = "Elderly",
            //    CreatedDate = DateTime.Now
            //};

            //var cause4 = new Cause
            //{
            //    CauseName = "Education",
            //    CreatedDate = DateTime.Now
            //};

            //var cause5 = new Cause
            //{
            //    CauseName = "Woman",
            //    CreatedDate = DateTime.Now
            //};

            //var cause6 = new Cause
            //{
            //    CauseName = "Youth",
            //    CreatedDate = DateTime.Now
            //};
            //context.Causes.AddOrUpdate(c =>  new { c.CauseName,c.CreatedDate }, cause1, cause2, cause3, cause4, cause5, cause6);

            //var news1 = new News
            //{
            //    Title = "VF 3 - ôtô điện nhỏ nhất của VinFast ra mắt",
            //    Description = "Mẫu xe điện mini nhận đặt cọc từ tháng 9, dự kiến đến tay người dùng quý III sang năm, ra mắt chiều 8/6.",
            //    ImagePath = "/Uploads/images/VF3.png",
            //    Content = "<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tĐại diện VinFast cho biết, VF 3 sẽ l&agrave; mẫu xe nhỏ nhất trong dải sản phẩm của h&atilde;ng, thuộc ph&acirc;n kh&uacute;c Mini Car. Đ&acirc;y cũng l&agrave; mẫu xe cỡ nhỏ đầu ti&ecirc;n được h&atilde;ng n&agrave;y nghi&ecirc;n cứu v&agrave; ph&aacute;t triển dựa tr&ecirc;n đặc t&iacute;nh, th&oacute;i quen giao th&ocirc;ng của người ti&ecirc;u d&ugrave;ng trong nước.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tTrước đ&oacute;, &ocirc;ng Phạm Nhật Vượng, Chủ tịch Hội đồng quản trị Tập đo&agrave;n Vingroup cho biết, VinFast sẽ triển khai d&ograve;ng xe điện&nbsp;<a data-itm-added=\"1\" data-itm-source=\"#vn_source=Detail-OtoXeMay_ThiTruong_XeDien-4615320&amp;vn_campaign=Box-InternalLink&amp;vn_medium=Link-SieuNho&amp;vn_term=Desktop&amp;vn_thumb=0&amp;vn_test=B\" href=\"https://vnexpress.net/vinfast-sap-ra-mat-oto-dien-sieu-nho-4606404.html\" rel=\"dofollow\" style=\"margin: 0px; padding: 0px 0px 1px; box-sizing: border-box; text-rendering: optimizelegibility; color: rgb(7, 109, 182); text-decoration-line: none; position: relative; text-underline-position: under; border-bottom-width: 1px; border-bottom-style: solid;\">si&ecirc;u nhỏ</a>, mục ti&ecirc;u phủ to&agrave;n bộ c&aacute;c dải sản phẩm trong ph&acirc;n kh&uacute;c. &quot;Xe si&ecirc;u nhỏ&quot; m&agrave; &ocirc;ng Vượng nhắc tới tương đương c&aacute;c d&ograve;ng sub-compact ở thị trường nước ngo&agrave;i, tức nhỏ hơn những chiếc xe hạng A như Morning hay i10.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/VF3.png\" style=\"width: 1020px; height: 591px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tCụ thể, với chiều d&agrave;i tổng thể 3.114 mm, VF 3 ngắn hơn&nbsp;<a data-itm-added=\"1\" data-itm-source=\"#vn_source=Detail-OtoXeMay_ThiTruong_XeDien-4615320&amp;vn_campaign=Box-InternalLink&amp;vn_medium=Link-VinfastVf5&amp;vn_term=Desktop&amp;vn_thumb=0&amp;vn_test=B\" href=\"https://vnexpress.net/oto-xe-may/v-car/dong-xe/vinfast-vf-5-218\" rel=\"dofollow\" style=\"margin: 0px; padding: 0px 0px 1px; box-sizing: border-box; text-rendering: optimizelegibility; color: rgb(7, 109, 182); text-decoration-line: none; position: relative; text-underline-position: under; border-bottom-width: 1px; border-bottom-style: solid;\">VinFast VF 5</a>&nbsp;(3.965 mm), cũng ngắn hơn mẫu hatchback hạng A nhỏ nhất thị trường l&agrave; Kia Morning (3.595 mm). So với mẫu xe điện Trung Quốc của Wuling sắp b&aacute;n v&agrave;o qu&yacute; III, VF 3 nhỉnh hơn 197 mm chiều d&agrave;i. Ngo&agrave;i ra, th&ocirc;ng số trục cơ sở, chiều rộng v&agrave; cao chưa được h&atilde;ng xe Việt c&ocirc;ng bố.</p>\r\n<div data-set=\"dfp\" id=\"admbackground\" style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&nbsp;</div>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tTừ h&igrave;nh ảnh 3D, VF 3 c&oacute; thiết kế theo hướng vu&ocirc;ng vức, c&aacute; t&iacute;nh, mang phong c&aacute;ch SUV hầm hố, kh&aacute;c biệt với dải sản phẩm VinFast vốn mang thiết kế mềm mại. H&igrave;nh khối vu&ocirc;ng vức thể hiện qua đ&egrave;n chiếu s&aacute;ng, gương hậu, v&ograve;m lốp... Logo chữ V h&igrave;nh c&aacute;nh chim c&aacute;ch điệu, điểm nhận diện chung của c&aacute;c mẫu xe VinFast. Bộ v&agrave;nh k&iacute;ch thước 16 inch, khoảng s&aacute;ng gầm kh&aacute; lớn, hướng đến khả năng di chuyển đa địa h&igrave;nh.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/VF3-01.png\" style=\"width: 1020px; height: 655px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tXe c&oacute; cấu h&igrave;nh 2 cửa b&ecirc;n h&ocirc;ng v&agrave; 1 cửa ph&iacute;a sau, kh&ocirc;ng gian d&agrave;nh cho 5 người ngồi. Khoang l&aacute;i thiết kế đơn giản, chỉ c&oacute; m&agrave;n h&igrave;nh người l&aacute;i m&agrave; kh&ocirc;ng c&oacute; m&agrave;n giải tr&iacute; trung t&acirc;m. Xe c&oacute; hai bản Eco v&agrave; Plus, h&atilde;ng chưa c&ocirc;ng bố th&ocirc;ng số kỹ thuật về pin, hiệu suất cũng như tầm di chuyển.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&quot;Hai phi&ecirc;n bản của VF 3 sẽ c&oacute; khoảng gi&aacute; ph&ugrave; hợp khả năng tiếp cận của đa số người Việt&quot;, đại diện VinFast cho biết.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/VF3-02.png\" style=\"width: 1020px; height: 491px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tHiện mẫu xe rẻ nhất của VinFast l&agrave; VF 5 Plus, gi&aacute; b&aacute;n 458 triệu đồng (chưa gồm pin), muốn sở hữu pin, người d&ugrave;ng cần bỏ ra th&ecirc;m 80 triệu đồng. K&iacute;ch thước nhỏ gọn, gi&aacute; b&aacute;n dễ tiếp cận số đ&ocirc;ng v&agrave; th&acirc;n thiện m&ocirc;i trường l&agrave; yếu tố được h&atilde;ng xe Việt kỳ vọng VF 3 sẽ trở th&agrave;nh c&aacute;i t&ecirc;n ăn kh&aacute;ch, tương tự th&agrave;nh c&ocirc;ng trước đ&acirc;y của Fadil.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Car",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 1,
            //};
            //var news2 = new News
            //{
            //    Title = "Lexus GX 2024 ra mắt thế giới",
            //    Description = "GX thế hệ mới phát triển trên nền tảng GA-F giống Lexus LX, ngoại hình vuông vức, nội thất sang trọng hơn, bán ra từ đầu 2024.",
            //    ImagePath = "/Uploads/images/LexusGX.png",
            //    Content = "<p>\r\n\t<a data-itm-added=\"1\" data-itm-source=\"#vn_source=Detail-OtoXeMay_ThiTruong_TheGioi-4615780&amp;vn_campaign=Box-InternalLink&amp;vn_medium=Link-LexusGx&amp;vn_term=Desktop&amp;vn_thumb=0&amp;vn_test=B\" href=\"https://vnexpress.net/oto-xe-may/v-car/dong-xe/lexus-gx-175\" rel=\"dofollow\" style=\"margin: 0px; padding: 0px 0px 1px; box-sizing: border-box; text-rendering: optimizelegibility; color: rgb(7, 109, 182); text-decoration-line: none; position: relative; text-underline-position: under; border-bottom-width: 1px; border-bottom-style: solid; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">Lexus GX</a><span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">&nbsp;2024 thuộc mẫu SUV thế hệ thứ ba, ra đời để thay thế GX hiện tại giới thiệu từ năm 2010. GX thế hệ mới mang kiểu d&aacute;ng hầm hố hơn nhiều so với đời cũ, trang bị nhiều c&ocirc;ng nghệ hiện đại hơn. Theo kế hoạch, GX mới sẽ b&aacute;n ra từ đầu năm 2024 tr&ecirc;n to&agrave;n thế giới.</span></p>\r\n<p>\r\n\t<span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\"><img alt=\"\" src=\"/Uploads/images/LexusGX.png\" style=\"width: 1200px; height: 675px;\" /></span></p>\r\n<p>\r\n\t<span style=\"background-color: rgb(252, 250, 246); font-family: arial; font-size: 18px;\">Mẫu SUV hạng sang mới của Lexus ph&aacute;t triển dựa tr&ecirc;n nền tảng GA-F body-on-frame, nằm dưới&nbsp;</span><a data-itm-added=\"1\" data-itm-source=\"#vn_source=Detail-OtoXeMay_ThiTruong_TheGioi-4615780&amp;vn_campaign=Box-InternalLink&amp;vn_medium=Link-Lx&amp;vn_term=Desktop&amp;vn_thumb=0&amp;vn_test=B\" href=\"https://vnexpress.net/oto-xe-may/v-car/dong-xe/-lx-90\" rel=\"dofollow\" style=\"font-family: arial; font-size: 18px; margin: 0px; padding: 0px 0px 1px; box-sizing: border-box; text-rendering: optimizelegibility; color: rgb(7, 109, 182); text-decoration-line: none; position: relative; text-underline-position: under; border-bottom-width: 1px; border-bottom-style: solid;\">LX</a><span style=\"background-color: rgb(252, 250, 246); font-family: arial; font-size: 18px;\">&nbsp;600. Xe trang bị hệ thống treo trước xương đ&ograve;n k&eacute;p v&agrave; đa li&ecirc;n kết ở ph&iacute;a sau. GX 2024 sử dụng hệ thống trợ lực l&aacute;i điện tử, cho cảm gi&aacute;c l&aacute;i tốt hơn tr&ecirc;n đường trường v&agrave; địa h&igrave;nh, theo tuy&ecirc;n bố của Lexus. Kh&aacute;ch h&agrave;ng c&oacute; th&ecirc;m lựa chọn hệ thống treo th&iacute;ch ứng.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tBan đầu, thương hiệu xe sang Nhật Bản giới thiệu bản GX 550 đi k&egrave;m động cơ 3.4 V6 tăng &aacute;p k&eacute;p, c&ocirc;ng suất 349 m&atilde; lực, m&ocirc;-men xoắn cực đại 650 Nm, kết hợp hộp số tự động 10 cấp, sức k&eacute;o 3.629 kg đối với loại c&oacute; m&oacute;c k&eacute;o ti&ecirc;u chuẩn. Hệ dẫn động 4WD bốn b&aacute;nh to&agrave;n thời gian, bộ vi sai trung t&acirc;m chống trượt giới hạn Tosen. Bộ chuyển đổi giữa 4H v&agrave; 4L nhanh hơn so với GX thế hệ cũ.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tĐộng cơ mới n&agrave;y thay cho GX 460 2022 với cỗ m&aacute;y 4.6 V8 c&ocirc;ng suất 301 m&atilde; lực, m&ocirc;-men xoắn cực đại 446 Nm, hộp số tự động 6 cấp, k&egrave;m sức k&eacute;o 2.426 kg.</p>\r\n<div data-set=\"dfp\" id=\"admbackground\" style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&nbsp;</div>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tNgoại h&igrave;nh GX 2024 cơ bắp v&agrave; vu&ocirc;ng vức hơn thế hệ trước. Lưới tản nhiệt h&igrave;nh con suốt đặc trưng Lexus c&aacute;ch điệu. K&iacute;nh chắn gi&oacute; thẳng đứng hơn. Cốp chỉnh điện với k&iacute;nh mở ri&ecirc;ng v&agrave; mở cốp rảnh tay. GX mới c&oacute; 6 g&oacute;i trang bị, gồm Premium, Premium+, Overtrail v&agrave; Overtrail+.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tK&iacute;ch thước GX mới lớn hơn bản cũ, với chiều d&agrave;i 5.005 mm (d&agrave;i hơn 70 mm), rộng 2.117 mm (rộng hơn 95 mm), cao 1.935 mm (cao hơn 50 mm) v&agrave; chiều d&agrave;i cơ sở 2.850 mm (d&agrave;i hơn 60 mm<strong style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility;\">)</strong>.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tG&oacute;i trang bị Overtrail cao cấp với c&aacute;c điểm nhấn m&agrave;u đen tr&ecirc;n chắn b&ugrave;n, ốp gầm bằng nh&ocirc;m, v&agrave;nh 18 inch với lốp 33 inch. Ngo&agrave;i ra xe c&ograve;n trang bị hệ thống hỗ trợ đổ đ&egrave;o, m&agrave;n h&igrave;nh 3D cho off-road, hệ thống treo động học điện tử. Bản Overtrail+ trang bị ghế đặc biệt, chức năng massage.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tTrong khi ngoại h&igrave;nh chắc chắn hơn bất kỳ chiếc GX n&agrave;o trước đ&acirc;y, th&igrave; c&aacute;c nh&agrave; thiết kế lại ưu ti&ecirc;n sự sang trọng trong cabin. GX thế hệ mới lắp cụm đồng hồ kỹ thuật số 12,3 inch (bản cũ l&agrave; đồng hồ analog t&iacute;ch hợp LCD), m&agrave;n h&igrave;nh cảm ứng giải tr&iacute; 14 inch mới so với 10,3 inch hiện tại, hỗ trợ kết nối kh&ocirc;ng d&acirc;y Apple CarPlay/Android Auto. C&aacute;c n&uacute;t vận h&agrave;nh hộp số v&agrave; bộ vi sai nằm ở ph&iacute;a sau lẫy chuyển số tr&ecirc;n bảng điều khiển trung t&acirc;m. T&ugrave;y chọn m&agrave;n h&igrave;nh k&iacute;nh l&aacute;i HUD.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tNội thất thiết lập hai cấu h&igrave;nh, 6 hoặc 7 chỗ. Ghế bọc da v&agrave; ốp gỗ cao cấp. H&agrave;ng ghế trước c&oacute; sưởi v&agrave; th&ocirc;ng gi&oacute; ti&ecirc;u chuẩn, h&agrave;ng thứ hai t&ugrave;y chọn sưởi.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tNăm 2022,&nbsp;<a data-itm-added=\"1\" data-itm-source=\"#vn_source=Detail-OtoXeMay_ThiTruong_TheGioi-4615780&amp;vn_campaign=Box-InternalLink&amp;vn_medium=Link-LexusGx&amp;vn_term=Desktop&amp;vn_thumb=0&amp;vn_test=B\" href=\"https://vnexpress.net/oto-xe-may/v-car/dong-xe/lexus-gx-175\" rel=\"dofollow\" style=\"margin: 0px; padding: 0px 0px 1px; box-sizing: border-box; text-rendering: optimizelegibility; color: rgb(7, 109, 182); text-decoration-line: none; position: relative; text-underline-position: under; border-bottom-width: 1px; border-bottom-style: solid;\">Lexus GX</a>&nbsp;b&aacute;n được 29.945 chiếc, giảm 7,9% so với 32.509 chiếc v&agrave;o năm 2021, theo&nbsp;<em style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility;\">Motor1</em>.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tLexus GX ph&acirc;n phối ch&iacute;nh h&atilde;ng tại thị trường Việt Nam với một phi&ecirc;n bản GX 460, gi&aacute; 5,97 tỷ đồng.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Car",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 2,
            //};
            //var news3 = new News
            //{
            //    Title = "Tác giả Việt thắng giải ảnh đại dương quốc tế",
            //    Description = "Nguyễn Ngọc Thiện là tác giả Việt Nam duy nhất đoạt giải cuộc thi \"Nhiếp ảnh đại dương quốc tế 2023\", hạng mục Những rạn san hô trên thế giới và Chân dung động vật biển.",
            //    ImagePath = "/Uploads/images/VuonSanHo.png",
            //    Content = "<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tKết quả cuộc thi được Tổ chức Bảo tồn đại dương Ocean Geographic Society (OGS) v&agrave; tạp ch&iacute; Hải dương học Ocean Geographic (OG) c&ocirc;ng bố đầu th&aacute;ng 6. Theo đ&oacute; nhiếp ảnh gia Nguyễn Ngọc Thiện l&agrave; t&aacute;c giả người Việt duy nhất c&oacute; ảnh đoạt giải, gồm giải nh&igrave; ở hạng mục &quot;Những rạn san h&ocirc; tr&ecirc;n thế giới&quot;, với t&aacute;c phẩm &quot;Vườn san h&ocirc; H&ograve;n Yến&quot; chụp tại v&ugrave;ng biển Ph&uacute; Y&ecirc;n v&agrave; giải khuyến kh&iacute;ch ở hạng mục &quot;Ch&acirc;n dung động vật&quot; với t&aacute;c phẩm &quot;C&aacute; n&oacute;c v&agrave; cốc nhựa&quot; chụp trong chuyến lặn biển ở quần đảo Nam Du, Ki&ecirc;n Giang.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/VuonSanHo.png\" style=\"width: 990px; height: 660px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tViệt Nam hiện c&oacute; khoảng tr&ecirc;n 1.100 km2 rạn san h&ocirc;. H&ograve;n Yến c&ograve;n l&agrave; nơi c&oacute; hệ sinh th&aacute;i phong ph&uacute; cả dưới nước v&agrave; tr&ecirc;n cạn với t&iacute;nh đa dạng sinh học cao. Kết quả nghi&ecirc;n cứu năm 2022 của Trung t&acirc;m Nhiệt đới Việt - Nga (Bộ Quốc ph&ograve;ng) đ&atilde; ghi nhận c&oacute; 22 lo&agrave;i san h&ocirc; thuộc 7 họ tại H&ograve;n Yến, nhiều lo&agrave;i chỉ được ghi nhận ở v&ugrave;ng biển tỉnh Ph&uacute; Y&ecirc;n, điển h&igrave;nh đ&oacute; l&agrave; san h&ocirc; mềm thuộc họ Alcyoniidae v&agrave; san h&ocirc; lỗ đỉnh (chi Lobophytum).</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&quot;Những bức ảnh san h&ocirc; trở n&ecirc;n ấn tượng hơn khi chụp s&oacute;ng biển ph&acirc;n t&aacute;ch cảnh quan độc đ&aacute;o giữa hai thế giới - tr&ecirc;n mặt nước v&agrave; dưới mặt nước c&ugrave;ng l&uacute;c trong c&ugrave;ng một khung h&igrave;nh, bằng kỹ thuật chụp underwater split-shots&quot;, anh Thiện m&ocirc; tả kỹ thuật chụp bức ảnh đoạt giải nh&igrave;.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/CaNoc.png\" style=\"width: 990px; height: 743px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tCuộc thi Nhiếp ảnh đại dương quốc tế được tổ chức thường ni&ecirc;n, vinh danh những t&aacute;c phẩm ấn tượng nhất li&ecirc;n quan đến đại dương, qua đ&oacute; truyền tải kiến thức v&agrave; lan tỏa th&ocirc;ng điệp bảo tồn m&ocirc;i trường, hệ sinh th&aacute;i đại dương.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t2023 l&agrave; năm thứ 10 cuộc thi được tổ chức, gồm 17 hạng mục ảnh: c&aacute;c rạn san h&ocirc; tr&ecirc;n thế giới, h&agrave;nh vi động vật biển, ch&acirc;n dung động vật biển hay mối li&ecirc;n hệ giữa con người v&agrave; đại dương... Tổng giải thưởng trị gi&aacute; 90.000 USD.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Science",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 1,
            //};
            //var news4 = new News
            //{
            //    Title = "Honda CR-V 2024 dùng động cơ hybrid",
            //    Description = "Honda CR-V Sport-L được định vị dưới phiên bản Sport Touring và có giá bán từ 37.645 USD.",
            //    ImagePath = "/Uploads/images/HondaCRV-01.png",
            //    Content = "<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">Honda Bắc Mỹ vừa bổ sung cho mẫu CR-V phi&ecirc;n bản Sport-L. Phi&ecirc;n bản n&agrave;y được định vị ở giữa bản EX-L v&agrave; Sport Touring.</span><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px; background-color: rgb(255, 255, 255);\">Honda CR-V Sport-L c&oacute; nhiều chi tiết nhận biết như c&aacute;c đường trang tr&iacute; m&agrave;u đen b&oacute;ng b&ecirc;n ngo&agrave;i, la-zăng 18 inch sơn đen, ống xả h&igrave;nh chữ nhật.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px; background-color: rgb(255, 255, 255);\"><img alt=\"\" src=\"/Uploads/images/HondaCRV-01.png\" style=\"width: 990px; height: 557px;\" /></span></p>\r\n<div data-set=\"dfp\" id=\"admbackground\" style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&nbsp;</div>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">B&ecirc;n trong khoang l&aacute;i, phi&ecirc;n bản mới n&agrave;y được trang bị m&agrave;n h&igrave;nh giải tr&iacute; trung t&acirc;m 9 inch hỗ trợ Apple CarPlay/Android Auto, sạc kh&ocirc;ng d&acirc;y v&agrave; hệ thống &acirc;m thanh 8 loa. C&aacute;c trang bị kh&aacute;c tr&ecirc;n CR-V Sport-L kh&ocirc;ng c&oacute; g&igrave; kh&aacute;c biệt.</span><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px; background-color: rgb(255, 255, 255);\">Phi&ecirc;n bản Sport-L d&ugrave;ng động cơ hybrid 2.0L tương tự bản Sport v&agrave; Sport Touring. Khối động cơ n&agrave;y cho c&ocirc;ng suất 204 m&atilde; lực, m&ocirc;-men xoắn cực đại 335 Nm. Tại thị trường Mỹ, c&aacute;c phi&ecirc;n bản CR-V d&ugrave;ng động cơ hybrid chiếm hơn 50% doanh số b&aacute;n h&agrave;ng.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/HondaCRV-02.png\" style=\"width: 990px; height: 557px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">Ngo&agrave;i động cơ hybrid, CR-V b&aacute;n tại Bắc Mỹ c&ograve;n c&oacute; động cơ xăng tăng &aacute;p 1.5L mạnh 190 m&atilde; lực v&agrave; 242,6 Nm.</span><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">Honda CR-V 2024 tại Mỹ cũng c&oacute; sự điều chỉnh về gi&aacute; theo hướng tăng l&ecirc;n. T&ugrave;y theo phi&ecirc;n bản, mức tăng dao động từ&nbsp;</span><abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; font-size: 19.008px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: sans-serif;\">400 USD</abbr><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">&nbsp;đến&nbsp;</span><abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; font-size: 19.008px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: sans-serif;\">1.090 USD</abbr><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">. Gi&aacute; b&aacute;n khởi điểm của CR-V 2024 tại Mỹ l&agrave;&nbsp;</span><abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; font-size: 19.008px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: sans-serif;\">30.795 USD</abbr><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">&nbsp;cho bản LX 2WD, đắt nhất&nbsp;</span><abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; font-size: 19.008px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: sans-serif;\">40.795 USD</abbr><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">&nbsp;cho bản Sport-Touring.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\"><img alt=\"\" src=\"/Uploads/images/HondaCRV-03.png\" style=\"width: 990px; height: 557px;\" /></span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">Tại Việt Nam, Honda CR-V đang được b&aacute;n với 4 phi&ecirc;n bản l&agrave; E, G, L v&agrave; LSE. Gi&aacute; b&aacute;n dao động từ 998 triệu đồng đến&nbsp;</span><abbr class=\"rate-vnd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; font-size: 19.008px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: sans-serif;\">1,138 tỷ đồng</abbr><span style=\"color: rgb(51, 51, 51); font-family: sans-serif; font-size: 19.008px;\">.</span></p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Car",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 1,
            //};
            //var news5 = new News
            //{
            //    Title = "Toyota đầu tư 328 triệu USD cho bán tải hybrid",
            //    Description = "Khoản đầu tư hàng trăm triệu USD được Toyota dành cho nhà máy ở Guanajuato (Mexico), nơi hãng xe Nhật Bản sản xuất các mẫu Tacoma hybrid.",
            //    ImagePath = "/Uploads/images/ToyotaTacoma-01.png",
            //    Content = "<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tTheo&nbsp;<em style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; background: transparent; text-size-adjust: 100%;\">Reuters</em>, Toyota sẽ đầu tư th&ecirc;m khoản tiền&nbsp;<abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; background: transparent; text-size-adjust: 100%;\">328 triệu USD</abbr>&nbsp;v&agrave;o nh&agrave; m&aacute;y ở bang Guanajuato thuộc miền trung Mexico. Được biết, khoản đầu tư của Toyota sẽ phục vụ những chuyển đổi trong quy tr&igrave;nh sản xuất phi&ecirc;n bản hybrid mới của b&aacute;n tải Tacoma.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\t&ldquo;Phi&ecirc;n bản mới của b&aacute;n tải Tacoma tại Mexico sẽ sử dụng động cơ hybrid. Như vậy, Guanajuato giờ đ&acirc;y sẽ l&agrave; một phần trong chiến lược sản xuất điện h&oacute;a của tập đo&agrave;n&rdquo;, Toyota cho biết.</p>\r\n<p>\r\n\t<img alt=\"\" src=\"/Uploads/images/ToyotaTacoma-01.png\" style=\"width: 990px; height: 661px;\" /></p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tB&ecirc;n cạnh đ&oacute;, Toyota x&aacute;c nhận c&aacute;c khoản đầu tư n&oacute;i tr&ecirc;n cũng sẽ gi&uacute;p điều chỉnh sản xuất những mẫu Tacoma mới phục vụ cho thị trường Bắc Mỹ trong tương lai.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tTừ khi c&ocirc;ng bố th&agrave;nh lập nh&agrave; m&aacute;y tại Guanajuato, Toyota đ&atilde; r&oacute;t v&agrave;o đ&acirc;y khoản đầu tư tổng cộng gần&nbsp;<abbr class=\"rate-usd\" style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; background: transparent; text-size-adjust: 100%;\">1,2 tỷ USD</abbr>, đồng thời gi&uacute;p mang đến hơn 2.500 việc l&agrave;m cho người d&acirc;n địa phương.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tTheo&nbsp;<em style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 0px; padding: 0px; border: 0px; vertical-align: baseline; background: transparent; text-size-adjust: 100%;\">Reuters</em>, kh&ocirc;ng chỉ Toyota, nhiều nh&agrave; sản xuất &ocirc;t&ocirc; tr&ecirc;n to&agrave;n thế giới đang chuyển dịch sản xuất từ động cơ đốt trong sang c&aacute;c biến thể chạy điện nhằm tu&acirc;n thủ c&aacute;c quy định nghi&ecirc;m ngặt hơn về kh&iacute; thải.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tTr&ecirc;n thực tế, Mexico được xem l&agrave; c&ocirc;ng xưởng &ocirc;t&ocirc; điện nhưng lại chủ yếu xuất khẩu sản phẩm sang c&aacute;c quốc gia kh&aacute;c như Mỹ. Nguy&ecirc;n nh&acirc;n của t&igrave;nh trạng n&agrave;y được cho l&agrave; v&igrave; &ocirc;t&ocirc; điện tỏ ra qu&aacute; đắt đỏ tại Mexico, trong khi mạng lưới trạm sạc tại quốc gia Bắc Mỹ n&agrave;y cũng chưa thực sự ho&agrave;n thiện.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\t<img alt=\"\" src=\"/Uploads/images/ToyotaTacoma-02.png\" style=\"width: 990px; height: 700px;\" /></p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tHiện, Mexico sở hữu khoảng 1.100 trạm sạc, tập trung chủ yếu ở c&aacute;c th&agrave;nh phố lớn v&agrave; l&agrave; nguy&ecirc;n nh&acirc;n khiến việc l&aacute;i xe điện đường d&agrave;i bị hạn chế. C&aacute;c nh&agrave; ph&acirc;n t&iacute;ch trong ng&agrave;nh nhận định xe hybrid c&oacute; thể l&agrave; một giải ph&aacute;p hợp l&yacute; trước khi quốc gia n&agrave;y nhận được nhiều khoản đầu tư hơn cho mảng &ocirc;t&ocirc; thuần điện.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tHồi th&aacute;ng 3, Tesla cũng tiết lộ kế hoạch x&acirc;y dựng một Gigafactory tại bang Nuevo Leon của Mexico trong nỗ lực mở rộng sản lượng to&agrave;n cầu.</p>\r\n<p style=\"box-sizing: border-box; text-rendering: geometricprecision; outline: 0px; -webkit-font-smoothing: antialiased; margin: 18px 0px; padding: 0px; border: 0px; font-size: 17.6px; vertical-align: baseline; background-image: initial; background-position: initial; background-size: initial; background-repeat: initial; background-attachment: initial; background-origin: initial; background-clip: initial; text-size-adjust: 100%; color: rgb(51, 51, 51); font-family: &quot;Noto Serif&quot;, serif;\">\r\n\tTrước đ&oacute; tại hội nghị thượng đỉnh về kh&iacute; hậu COP27, Mexico đ&atilde; cam kết 50% doanh số &ocirc;t&ocirc; của quốc gia n&agrave;y sẽ l&agrave; phương tiện kh&ocirc;ng ph&aacute;t thải v&agrave;o năm 2030.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Car",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 1,
            //};
            //var news6 = new News
            //{
            //    Title = "Thí nghiệm 'cân' Trái Đất cách đây hơn 200 năm",
            //    Description = "Năm 1798, nhà khoa học Henry Cavendish thực hiện thí nghiệm với các khối cầu trong phòng kín và tối, tính ra gần đúng khối lượng riêng của Trái Đất.",
            //    ImagePath = "/Uploads/images/Earth.png",
            //    Content = "<p>\r\n\t<span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">Cuối những năm 1600, nh&agrave; khoa học Isaac Newton đưa ra định luật vạn vật hấp dẫn: Mọi hạt đều hấp dẫn mọi hạt kh&aacute;c trong vũ trụ bằng một lực (F) được quyết định bởi khối lượng của ch&uacute;ng (M) v&agrave; b&igrave;nh phương khoảng c&aacute;ch giữa t&acirc;m của c&aacute;c vật thể (R). Với G l&agrave; hằng số hấp dẫn, phương tr&igrave;nh cho định luật n&agrave;y l&agrave;: F = G(M1xM2/R</span><sup style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; background-color: rgb(252, 250, 246);\">2</sup><span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">).</span></p>\r\n<p>\r\n\t<span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\"><img alt=\"\" src=\"/Uploads/images/Earth.png\" style=\"width: 990px; height: 594px;\" /></span></p>\r\n<p>\r\n\t<span style=\"background-color: rgb(252, 250, 246); font-family: arial; font-size: 18px;\">Như vậy, nếu biết khối lượng của một trong c&aacute;c vật thể v&agrave; những th&ocirc;ng tin kh&aacute;c của phương tr&igrave;nh, người ta c&oacute; thể t&iacute;nh ra khối lượng của vật thể thứ hai. Coi một người l&agrave; khối lượng đ&atilde; biết, người n&agrave;y c&oacute; thể t&iacute;nh ra khối lượng Tr&aacute;i Đất nếu biết m&igrave;nh c&aacute;ch t&acirc;m Tr&aacute;i Đất khoảng bao xa. Vấn đề l&agrave; v&agrave;o thời Newton, giới khoa học chưa x&aacute;c định được G n&ecirc;n việc c&acirc;n Tr&aacute;i Đất l&agrave; bất khả thi.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tViệc biết khối lượng v&agrave; khối lượng ri&ecirc;ng của Tr&aacute;i Đất sẽ v&ocirc; c&ugrave;ng hữu &iacute;ch với c&aacute;c nh&agrave; thi&ecirc;n văn học v&igrave; gi&uacute;p họ t&iacute;nh to&aacute;n khối lượng v&agrave; khối lượng ri&ecirc;ng của c&aacute;c vật thể kh&aacute;c trong hệ Mặt Trời. Năm 1772, Hội Ho&agrave;ng gia London th&agrave;nh lập &quot;Ủy ban Hấp dẫn&quot; để nghi&ecirc;n cứu điều n&agrave;y.</p>\r\n<div data-set=\"dfp\" id=\"admbackground\" style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&nbsp;</div>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tNăm 1774, một nh&oacute;m chuy&ecirc;n gia cố gắng đo khối lượng ri&ecirc;ng trung b&igrave;nh của Tr&aacute;i Đất th&ocirc;ng qua n&uacute;i Schiehallion ở Scotland. Họ chỉ ra rằng khối lượng đồ sộ của Schiehallion đ&atilde; h&uacute;t c&aacute;c con lắc về ph&iacute;a đ&oacute;. V&igrave; vậy, họ t&iacute;nh to&aacute;n khối lượng ri&ecirc;ng của Tr&aacute;i Đất nhờ đo chuyển động của con lắc v&agrave; khảo s&aacute;t ngọn n&uacute;i. Tuy nhi&ecirc;n, ph&eacute;p đo n&agrave;y c&oacute; độ ch&iacute;nh x&aacute;c kh&ocirc;ng cao.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t<img alt=\"\" src=\"/Uploads/images/EarthWeight.png\" style=\"width: 990px; height: 594px;\" /></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tNh&agrave; địa chất Reverend John Michell cũng nghi&ecirc;n cứu về khối lượng Tr&aacute;i Đất nhưng kh&ocirc;ng thể ho&agrave;n th&agrave;nh trước khi chết. Nh&agrave; khoa học Anh Henry Cavendish đ&atilde; sử dụng c&aacute;c thiết bị của Michell để thực hiện th&iacute; nghiệm.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\t&Ocirc;ng chế tạo một quả tạ lớn, với những khối cầu bằng ch&igrave; rộng 5 cm gắn v&agrave;o hai đầu của thanh gỗ d&agrave;i 183 cm. Thanh gỗ được treo l&ecirc;n một sợi d&acirc;y ở t&acirc;m v&agrave; c&oacute; thể xoay tự do. Sau đ&oacute;, quả tạ thứ hai với hai khối cầu bằng ch&igrave; rộng 30 cm, nặng 159 kg mỗi khối, được đưa đến gần quả tạ thứ nhất để những khối cầu lớn h&uacute;t những khối nhỏ, t&aacute;c dụng một lực nhẹ l&ecirc;n thanh treo. Cavendish chăm ch&uacute; theo d&otilde;i dao động của thanh n&agrave;y suốt nhiều giờ.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tLực hấp dẫn giữa c&aacute;c khối cầu rất yếu n&ecirc;n luồng kh&ocirc;ng kh&iacute; nhỏ nhất cũng c&oacute; thể ph&aacute; hỏng th&iacute; nghiệm tinh vi n&agrave;y. Cavendish đặt thiết bị trong ph&ograve;ng k&iacute;n để tr&aacute;nh luồng kh&ocirc;ng kh&iacute; b&ecirc;n ngo&agrave;i. &Ocirc;ng d&ugrave;ng k&iacute;nh viễn vọng để quan s&aacute;t th&iacute; nghiệm qua cửa sổ v&agrave; thiết lập một hệ thống r&ograve;ng rọc để di chuyển c&aacute;c quả tạ từ b&ecirc;n ngo&agrave;i. Căn ph&ograve;ng được giữ tối để tr&aacute;nh xảy ra ch&ecirc;nh lệch nhiệt độ giữa những chỗ kh&aacute;c nhau trong ph&ograve;ng, ảnh hưởng đến th&iacute; nghiệm.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tTh&aacute;ng 6/1798, Cavendish c&ocirc;ng bố c&aacute;c kết quả của m&igrave;nh t&ecirc;n tạp ch&iacute;&nbsp;<em style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility;\">Transactions of the Royal Society&nbsp;</em>trong nghi&ecirc;n cứu mang t&ecirc;n &quot;Th&iacute; nghiệm x&aacute;c định khối lượng ri&ecirc;ng của Tr&aacute;i Đất&quot;. &Ocirc;ng tr&igrave;nh b&agrave;y rằng khối lượng ri&ecirc;ng của Tr&aacute;i Đất gấp 5,48 lần nước, hay 5,48 g/cm3, kh&aacute; gần với gi&aacute; trị hiện đại l&agrave; 5,51 g/cm3.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tTh&iacute; nghiệm của Cavendish c&oacute; &yacute; nghĩa quan trọng kh&ocirc;ng chỉ với việc đo khối lượng ri&ecirc;ng v&agrave; khối lượng của Tr&aacute;i Đất (ước t&iacute;nh khoảng 5,974 triệu tỷ tỷ kg) m&agrave; c&ograve;n chứng minh rằng định luật vạn vật hấp dẫn của Newton cũng đ&uacute;ng với quy m&ocirc; nhỏ hơn nhiều so với quy m&ocirc; của hệ Mặt Trời. Kể từ cuối thế kỷ 19, c&aacute;c phi&ecirc;n bản cải tiến của th&iacute; nghiệm Cavendish được sử dụng để x&aacute;c định G.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Science",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 1,
            //};
            //var news7 = new News
            //{
            //    Title = "Máy bay siêu thanh Mach 7 có thể cất cánh năm sau",
            //    Description = "Máy bay siêu thanh do công ty Hypersonix Launch Systems phát triển đang tiến gần đến chuyến bay thử tự động đầu tiên theo chương trình của Đơn vị sáng kiến quốc phòng Mỹ (DIU).",
            //    ImagePath = "/Uploads/images/DartAE.png",
            //    Content = "<p>\r\n\t<span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">M&aacute;y bay thử nghiệm tốc độ cao Dart AE đang được ph&aacute;t triển bởi c&ocirc;ng ty Australia Hypersonix Launch Systems sau hợp đồng với DIU. DART AE l&agrave; nguy&ecirc;n mẫu giới thiệu c&ocirc;ng nghệ, d&agrave;i 3 m v&agrave; nặng 300 kg, c&oacute; thể đạt tốc độ Mach 7 (8.643 km),&nbsp;</span><em style=\"margin: 0px; padding: 0px; box-sizing: border-box; text-rendering: optimizelegibility; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">Space&nbsp;</em><span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">h&ocirc;m 11/6 đưa tin. Phương tiện c&oacute; tầm hoạt động 1.000 km.</span></p>\r\n<p>\r\n\t<span style=\"font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\"><img alt=\"\" src=\"/Uploads/images/DartAE.png\" style=\"width: 990px; height: 594px;\" /></span></p>\r\n<p>\r\n\t<span style=\"background-color: rgb(252, 250, 246); font-family: arial; font-size: 18px;\">DART AE sử dụng bộ khung in 3D to&agrave;n bộ đầu ti&ecirc;n tr&ecirc;n thế giới từ hợp kim chịu nhiệt độ cao. Mẫu m&aacute;y bay sử dụng động cơ phản lực d&ograve;ng thẳng thế hệ thứ 5 của Hypersonix t&ecirc;n Spartan, cung cấp hiệu suất cao. DART AE c&oacute; thể ph&oacute;ng bằng t&ecirc;n lửa nghi&ecirc;n cứu kh&ocirc;ng người l&aacute;i, gi&uacute;p tiết kiệm chi ph&iacute; v&agrave; tăng t&iacute;nh linh hoạt cho nhiệm vụ.</span></p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tDART AE c&oacute; thể sẵn s&agrave;ng bay thử v&agrave;o đầu m&ugrave;a h&egrave; nằm trong nỗ lực của ch&iacute;nh phủ Mỹ nhằm th&uacute;c đẩy thử nghiệm bay si&ecirc;u thanh. Thuộc Bộ Quốc ph&ograve;ng Mỹ, DIU tập trung v&agrave;o đẩy mạnh ứng dụng c&ocirc;ng nghệ thương mại để giải quyết những th&aacute;ch thức về mặt vận h&agrave;nh khi bay ở tốc độ si&ecirc;u cao.</p>\r\n<p class=\"Normal\" style=\"margin: 0px 0px 1em; padding: 0px; box-sizing: border-box; text-rendering: optimizespeed; line-height: 28.8px; font-family: arial; font-size: 18px; background-color: rgb(252, 250, 246);\">\r\n\tCh&iacute;nh phủ Mỹ đang theo đuổi v&agrave; ph&aacute;t triển c&aacute;c chương tr&igrave;nh ph&ograve;ng thủ si&ecirc;u thanh. Theo đ&oacute;, DIU triển khai nhiều dự &aacute;n c&oacute; khả năng thử nghiệm cao, mang đến cơ hội cho những c&ocirc;ng ty thương mại ph&aacute;t triển phương tiện bay thử chi ph&iacute; thấp v&agrave; c&oacute; thể t&aacute;i sử dụng, qua đ&oacute; giảm bớt &aacute;p lực cho Bộ Quốc ph&ograve;ng.</p>\r\n",
            //    Author = "Nguyen Chanh Bao",
            //    TypeOfNews = "Science",
            //    CreatedDate = DateTime.Now,
            //    ModifiedDate = DateTime.Now,
            //    UserId = 2,
            //};
            //context.News.AddOrUpdate(n => new { n.Title, n.Description, n.ImagePath, n.Content, n.Author, n.TypeOfNews, n.CreatedDate, n.ModifiedDate, n.UserId }, news1, news2, news3, news4, news5, news6, news7);
        }
    }
}
