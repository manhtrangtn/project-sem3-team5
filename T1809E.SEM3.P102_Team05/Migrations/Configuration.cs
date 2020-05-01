using T1809E.SEM3.P102_Team05.Models;

namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using T1809E.SEM3.P102_Team05.Models;
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
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Orders");
            context.Orders.AddOrUpdate(new Order()
            {
                OrderId=1,
                CustomerID=101,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 2,
                CustomerID = 102,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-02-17"),
                UpdatedAt = DateTime.Parse("2019-02-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 3,
                CustomerID = 103,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-03-13"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-04-30"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 4,
                CustomerID = 104,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-17"),
                UpdatedAt = DateTime.Parse("2019-04-25"),
                DeletedAt = DateTime.Parse("2019-05-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 5,
                CustomerID = 105,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2019-05-17"),
                UpdatedAt = DateTime.Parse("2019-05-25"),
                DeletedAt = DateTime.Parse("2019-06-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 6,
                CustomerID = 106,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-06-17"),
                UpdatedAt = DateTime.Parse("2019-06-25"),
                DeletedAt = DateTime.Parse("2019-07-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 7,
                CustomerID = 107,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-07-17"),
                UpdatedAt = DateTime.Parse("2019-07-25"),
                DeletedAt = DateTime.Parse("2019-08-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 8,
                CustomerID = 108,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760000,
                CreatedAt = DateTime.Parse("2019-08-17"),
                UpdatedAt = DateTime.Parse("2019-08-25"),
                DeletedAt = DateTime.Parse("2019-09-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 9,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2019-09-17"),
                UpdatedAt = DateTime.Parse("2019-09-25"),
                DeletedAt = DateTime.Parse("2019-10-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 10,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-07"),
                UpdatedAt = DateTime.Parse("2019-01-15"),
                DeletedAt = DateTime.Parse("2019-02-19"),
                OrderStatus1.ACTIVE
            });
            
            
        }
    }
}
