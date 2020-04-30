using T1809E.SEM3.P102_Team05.Models;

namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<T1809E.SEM3.P102_Team05.Data.AppDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(T1809E.SEM3.P102_Team05.Data.AppDatabaseContext context)
        {
            // context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            // context.Products.AddOrUpdate(new Product()
            // {
            //     Id = 1,
            //     Name = "Kem Đánh Răng",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2446/86596/bhx/kdr-sensodyne-trang-sang-100g-2-700x467.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-15"),
            //     DeleteAt = DateTime.Parse("2019-02-03"),
            //     InStock = 1,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 2,
            //     Name = "Bàn Chải",
            //     Thumbnail = "https://phugiatrading.com/wp-content/uploads/2019/02/ban-chai-danh-rang-han-quoc-bio-care-crystal-nano-gold-1001g-2-1.jpg",
            //     Price = 15000,
            //     CreateAt = DateTime.Parse("2019-01-04"),
            //     UpdateAt = DateTime.Parse("2019-01-16"),
            //     DeleteAt = DateTime.Parse("2019-02-04"),
            //     InStock = 2,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 3,
            //     Name = "Dầu Gội",
            //     Thumbnail = "https://depcosmetics.vn/wp-content/uploads/2017/01/8934868113652_1.jpg",
            //     Price = 65000,
            //     CreateAt = DateTime.Parse("2019-01-05"),
            //     UpdateAt = DateTime.Parse("2019-01-17"),
            //     DeleteAt = DateTime.Parse("2019-02-07"),
            //     InStock = 3,
            //     Status = OrderStatus.ACTIVE
            // }, new Product()
            // {
            //     Id = 4,
            //     Name = "Dầu Rửa Bát",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-18"),
            //     DeleteAt = DateTime.Parse("2019-02-06"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 5,
            //     Name = "Áo Len",
            //     Thumbnail = "https://bizweb.dktcdn.net/100/107/464/files/9498404712-307052022.jpg?v=1564733482956",
            //     Price = 105000,
            //     CreateAt = DateTime.Parse("2019-01-15"),
            //     UpdateAt = DateTime.Parse("2019-01-20"),
            //     DeleteAt = DateTime.Parse("2019-02-13"),
            //     InStock = 3,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 6,
            //     Name = "Áo Sơ Mi",
            //     Thumbnail = "https://salt.tikicdn.com/cache/550x550/ts/product/8e/4d/53/27b355f238f46235c9fefcd07a1cfd0e.jpg",
            //     Price = 75000,
            //     CreateAt = DateTime.Parse("2019-01-12"),
            //     UpdateAt = DateTime.Parse("2019-01-21"),
            //     DeleteAt = DateTime.Parse("2019-02-05"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 7,
            //     Name = "Dầu Rửa Bát",
            //     Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
            //     Price = 25000,
            //     CreateAt = DateTime.Parse("2019-01-03"),
            //     UpdateAt = DateTime.Parse("2019-01-25"),
            //     DeleteAt = DateTime.Parse("2019-02-23"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 8,
            //     Name = "Quần Jean",
            //     Thumbnail = "https://vn-live-03.slatic.net/original/7efdce91f32f7004c953ddc8a22216d4.jpg",
            //     Price = 135000,
            //     CreateAt = DateTime.Parse("2019-02-23"),
            //     UpdateAt = DateTime.Parse("2019-03-15"),
            //     DeleteAt = DateTime.Parse("2019-03-24"),
            //     InStock = 19,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 9,
            //     Name = "Áo Khoác nam",
            //     Thumbnail = "https://bizweb.dktcdn.net/thumb/large/100/180/420/products/750x750-1-1.jpg",
            //     Price = 225000,
            //     CreateAt = DateTime.Parse("2019-03-13"),
            //     UpdateAt = DateTime.Parse("2019-03-15"),
            //     DeleteAt = DateTime.Parse("2019-04-03"),
            //     InStock = 40,
            //     Status = OrderStatus.ACTIVE
            // },
            // new Product()
            // {
            //     Id = 10,
            //     Name = "Áo khoác nữ",
            //     Thumbnail = "https://quanaogiaxuong.com/wp-content/uploads/8947-clean-z1437963267757-960adcd8edf1993390eb7cec2fc8f9dc.jpg",
            //     Price = 235000,
            //     CreateAt = DateTime.Parse("2019-01-17"),
            //     UpdateAt = DateTime.Parse("2019-01-25"),
            //     DeleteAt = DateTime.Parse("2019-02-30"),
            //     InStock = 4,
            //     Status = OrderStatus.ACTIVE
            // });
        }
    }
}
