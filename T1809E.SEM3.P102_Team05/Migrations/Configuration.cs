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
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            context.Products.AddOrUpdate(new Product()
            {
                Id = 1,
                Name = "Kem Đánh Răng",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2446/86596/bhx/kdr-sensodyne-trang-sang-100g-2-700x467.jpg",
                Price = 25000,
                CreateAt = DateTime.Parse("01/03/2019"),
                InStock = 1,
                Status= OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 2,
                Name = "Bàn Chải",
                Thumbnail = "https://phugiatrading.com/wp-content/uploads/2019/02/ban-chai-danh-rang-han-quoc-bio-care-crystal-nano-gold-1001g-2-1.jpg",
                Price = 15000,
                CreateAt = DateTime.Parse("12/03/2019"),
                InStock = 2,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 3,
                Name = "Dầu Gội",
                Thumbnail = "https://depcosmetics.vn/wp-content/uploads/2017/01/8934868113652_1.jpg",
                Price = 65000,
                CreateAt = DateTime.Parse("18/02/2019"),
                InStock = 3,
                Status = OrderStatus.DISABLE
            }, new Product()
            {
                Id = 4,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreateAt = DateTime.Parse("15/01/2019"),
                InStock = 4,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 5,
                Name = "Áo Len",
                Thumbnail = "https://bizweb.dktcdn.net/100/107/464/files/9498404712-307052022.jpg?v=1564733482956",
                Price = 105000,
                CreateAt = DateTime.Parse("08/04/2019"),
                InStock = 3,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 6,
                Name = "Áo Sơ Mi",
                Thumbnail = "https://salt.tikicdn.com/cache/550x550/ts/product/8e/4d/53/27b355f238f46235c9fefcd07a1cfd0e.jpg",
                Price = 75000,
                CreateAt = DateTime.Parse("25/05/2019"),
                InStock = 4,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 7,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreateAt = DateTime.Parse("19/06/2019"),
                InStock = 4,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 8,
                Name = "Quần Jean",
                Thumbnail = "https://vn-live-03.slatic.net/original/7efdce91f32f7004c953ddc8a22216d4.jpg",
                Price = 135000,
                CreateAt = DateTime.Parse("22/08/2019"),
                InStock = 19,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 9,
                Name = "Áo Khoác nam",
                Thumbnail = "https://bizweb.dktcdn.net/thumb/large/100/180/420/products/750x750-1-1.jpg",
                Price = 225000,
                CreateAt = DateTime.Parse("01/09/2019"),
                InStock = 40,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 10,
                Name = "Áo khoác nữ",
                Thumbnail = "https://quanaogiaxuong.com/wp-content/uploads/8947-clean-z1437963267757-960adcd8edf1993390eb7cec2fc8f9dc.jpg",
                Price = 235000,
                CreateAt = DateTime.Parse("29/10/2019"),
                InStock = 4,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 11,
                Name = "Áo phông nam",
                Thumbnail = "https://shopmc.vn/wp-content/uploads/2017/03/Ao-phong-BHGaming-Minecraft.jpg",
                Price = 55000,
                CreateAt = DateTime.Parse("15/07/2019"),
                InStock = 70,
                Status = OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 12,
                Name = "Áo phông nữ",
                Thumbnail = "https://kenhphunu.com/media/102015/1559754000/ao_phong_trang.jpg",
                Price = 55000,
                CreateAt = DateTime.Parse("15/12/2019"),
                InStock = 80,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 13,
                Name = "quần Baggy",
                Thumbnail = "https://nocturnal.vn/wp-content/uploads/2019/09/3-600x600.jpg",
                Price = 115000,
                CreateAt = DateTime.Parse("15/01/2020"),
                InStock = 100,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 14,
                Name = "Áo Hoodie",
                Thumbnail = "https://media3.scdn.vn/img3/2019/11_2/SQIy05_simg_de2fe0_500x500_maxb.jpg",
                Price = 135000,
                CreateAt = DateTime.Parse("07/01/2020"),
                InStock = 80,
                Status = OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 15,
                Name = "Áo Thun nữ",
                Thumbnail = "https://aothuntrongiasi.com/wp-content/uploads/2018/04/ao-thun-trang-nu-1.jpg",
                Price = 75000,
                CreateAt = DateTime.Parse("02/02/2020"),
                InStock = 110,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 16,
                Name = "quần short nam",
                Thumbnail = "https://img.zanado.com/media/catalog/product/cache/all/thumbnail/360x420/7b8fef0172c2eb72dd8fd366c999954c/7/_/quan_short_nam_tron_pa_e7c5.jpg",
                Price = 95000,
                CreateAt = DateTime.Parse("24/03/2020"),
                InStock = 60,
                Status = OrderStatus.DELETED
            },
            new Product()
            {
                Id = 17,
                Name = "Quần áo thể thao",
                Thumbnail = "https://media3.scdn.vn/img2/2018/5_3/bdEfl8_simg_de2fe0_500x500_maxb.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("15/02/2020"),
                InStock = 140,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 18,
                Name = "Áo dạ nam",
                Thumbnail = "https://media3.scdn.vn/img3/2019/10_3/eDADlp_simg_de2fe0_500x500_maxb.png",
                Price = 450000,
                CreateAt = DateTime.Parse("08/03/2020"),
                InStock = 10,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 19,
                Name = "Áo dạ nữ",
                Thumbnail = "https://media3.scdn.vn/img3/2018/12_22/tXJbuH_simg_de2fe0_500x500_maxb.jpg",
                Price = 455000,
                CreateAt = DateTime.Parse("29/03/2020"),
                InStock = 17,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 20,
                Name = "Áo Phao",
                Thumbnail = "https://dosityna.com/wp-content/uploads/2019/01/ao-phao-dep.jpg",
                Price = 355000,
                CreateAt = DateTime.Parse("10/04/2020"),
                InStock = 30,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 21,
                Name = "Quần jogger nam",
                Thumbnail = "https://quanjogger.vn/image/cache/catalog/quanjoggernam/kaki/500-620-quan-jogger-nam-xam-tieu-avatar-500x620.jpg",
                Price = 85000,
                CreateAt = DateTime.Parse("27/04/2020"),
                InStock = 190,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 22,
                Name = "quần jogger nữ",
                Thumbnail = "https://ann.com.vn/wp-content/uploads/11017-clean-857494ffd81821467809.jpg",
                Price = 85000,
                CreateAt = DateTime.Parse("02/04/2020"),
                InStock = 180,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 23,
                Name = "Áo sơ mi caro",
                Thumbnail = "https://file.hstatic.net/1000401164/file/ao-so-mi-nam-thoi-trang-mando-1_d129dc6d1a28427ead3f29bbb81d2225_grande.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("27/01/2020"),
                InStock = 240,
                Status = OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 24,
                Name = "Áo len dài tay",
                Thumbnail = "https://vcdn-ngoisao.vnecdn.net/2018/12/21/Ao-len-dai-tay-nam-Aristino-AW-3796-5251-1545389942.jpg",
                Price = 145000,
                CreateAt = DateTime.Parse("09/03/2020"),
                InStock = 120,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 25,
                Name = "Váy len",
                Thumbnail = "https://media3.scdn.vn/img2/2018/9_14/s52GxR_simg_de2fe0_500x500_maxb.jpg",
                Price = 95000,
                CreateAt = DateTime.Parse("28/4/2020"),
                InStock = 48,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 26,
                Name = "Quần vải nam",
                Thumbnail = "https://ragus.vn/wp-content/uploads/2019/04/Qu%E1%BA%A7n-V%E1%BA%A3i-Nam-Woven-%C4%91en-QV125007-2.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("01/05/2020"),
                InStock = 63,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 27,
                Name = "Quần áo cho bé",
                Thumbnail = "https://thoitrang.biz/wp-content/uploads/2014/12/bo-ao-lien-quan-hinh-thu-de-thuong-cho-cac-be-1.jpg",
                Price = 90000,
                CreateAt = DateTime.Parse("02/05/2020"),
                InStock = 54,
                Status = OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 28,
                Name = "Quần áo thun",
                Thumbnail = "https://www.bexinhshop.vn/image/data/17-1-2019/setdaydeonoCARO.jpg",
                Price = 120000,
                CreateAt = DateTime.Parse("26/04/2020"),
                InStock = 23,
                Status = OrderStatus.DISABLE
            },
            new Product()
            {
                Id = 29,
                Name = "Áo thu đông",
                Thumbnail = "https://mjumju.net/wp-content/uploads/2017/12/ao-thu-dong-nam-TD014-3.jpg",
                Price = 100000,
                CreateAt = DateTime.Parse("23/04/2020"),
                InStock = 61,
                Status = OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 30,
                Name = "Áo nỉ nam",
                Thumbnail = "https://linhvnxk.com/wp-content/uploads/2018/10/ao-ni-nam-xuat-han-tran-tram-15.jpg",
                Price = 115000,
                CreateAt = DateTime.Parse("01/05/2020"),
                InStock = 89,
                Status = OrderStatus.DISABLE
            });
            //context.Database.ExecuteSqlCommand("TRUNCATE TABLE Orders");
            //context.Orders.AddOrUpdate(new Order()
            //{
            //    OrderId=1,
            //    CustomerID=101,
            //    OrderNumber=2,
            //    ShippingAddress= "HA NOI",
            //    Total=100000,
            //    CreatedAt = DateTime.Parse("2019-01-17"),
            //    UpdatedAt = DateTime.Parse("2019-01-25"),
            //    DeletedAt = DateTime.Parse("2019-02-29"),
            //    OrderStatus11.ACTIVE
            //},new Order()
            //{
            //    OrderId = 2,
            //    CustomerID = 102,
            //    OrderNumber = 5,
            //    ShippingAddress = "Ha Tinh",
            //    Total = 150000,
            //    CreatedAt = DateTime.Parse("2019-02-17"),
            //    UpdatedAt = DateTime.Parse("2019-02-25"),
            //    DeletedAt = DateTime.Parse("2019-02-29"),
            //    OrderStatus1.ACTIVE
            //}, new Order()
            //{
            //    OrderId = 3,
            //    CustomerID = 103,
            //    OrderNumber = 2,
            //    ShippingAddress = "Hai Duong",
            //    Total = 145000,
            //    CreatedAt = DateTime.Parse("2019-03-13"),
            //    UpdatedAt = DateTime.Parse("2019-03-25"),
            //    DeletedAt = DateTime.Parse("2019-04-30"),
            //    OrderStatus1.DELETED
            //}, new Order()
            //{
            //    OrderId = 4,
            //    CustomerID = 104,
            //    OrderNumber = 1,
            //    ShippingAddress = "Vinh Phuc",
            //    Total = 100000,
            //    CreatedAt = DateTime.Parse("2019-04-17"),
            //    UpdatedAt = DateTime.Parse("2019-04-25"),
            //    DeletedAt = DateTime.Parse("2019-05-30"),
            //    OrderStatus1.ACTIVE
            //}, new Order()
            //{
            //    OrderId = 5,
            //    CustomerID = 105,
            //    OrderNumber = 5,
            //    ShippingAddress = "Ninh Binh",
            //    Total = 1400000,
            //    CreatedAt = DateTime.Parse("2019-05-17"),
            //    UpdatedAt = DateTime.Parse("2019-05-25"),
            //    DeletedAt = DateTime.Parse("2019-06-30"),
            //    OrderStatus1.ACTIVE
            //}, new Order()
            //{
            //    OrderId = 6,
            //    CustomerID = 106,
            //    OrderNumber = 7,
            //    ShippingAddress = "Long An",
            //    Total = 1500000,
            //    CreatedAt = DateTime.Parse("2019-06-17"),
            //    UpdatedAt = DateTime.Parse("2019-06-25"),
            //    DeletedAt = DateTime.Parse("2019-07-30"),
            //    OrderStatus1.DISABLE
            //}, new Order()
            //{
            //    OrderId = 7,
            //    CustomerID = 107,
            //    OrderNumber = 4,
            //    ShippingAddress = "Ha Long",
            //    Total = 100000,
            //    CreatedAt = DateTime.Parse("2019-07-17"),
            //    UpdatedAt = DateTime.Parse("2019-07-25"),
            //    DeletedAt = DateTime.Parse("2019-08-30"),
            //    OrderStatus1.ACTIVE
            //}, new Order()
            //{
            //    OrderId = 8,
            //    CustomerID = 108,
            //    OrderNumber = 5,
            //    ShippingAddress = "HA NOI",
            //    Total = 760000,
            //    CreatedAt = DateTime.Parse("2019-08-17"),
            //    UpdatedAt = DateTime.Parse("2019-08-25"),
            //    DeletedAt = DateTime.Parse("2019-09-30"),
            //    OrderStatus1.DISABLE
            //}, new Order()
            //{
            //    OrderId = 9,
            //    CustomerID = 109,
            //    OrderNumber = 18,
            //    ShippingAddress = "Hue",
            //    Total = 1600000,
            //    CreatedAt = DateTime.Parse("2019-09-17"),
            //    UpdatedAt = DateTime.Parse("2019-09-25"),
            //    DeletedAt = DateTime.Parse("2019-10-30"),
            //    OrderStatus1.ACTIVE
            //},
            //new Order()
            //{
            //    OrderId = 10,
            //    CustomerID = 110,
            //    OrderNumber = 3,
            //    ShippingAddress = "Sai Gon",
            //    Total = 900000,
            //    CreatedAt = DateTime.Parse("2019-01-07"),
            //    UpdatedAt = DateTime.Parse("2019-01-15"),
            //    DeletedAt = DateTime.Parse("2019-02-19"),
            //    OrderStatus1.ACTIVE
            //});
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE OrderDetails");
            context.OrderDetails.AddOrUpdate(new OrderDetail()
            {
                Id = 1,
                OrderID=1,
                ProductId=101,
                Price=20000,
                Quantity=2,
            },
            new OrderDetail()
            {
                Id = 2,
                OrderID = 2,
                ProductId = 101,
                Price = 20000,
                Quantity = 2,
            },
            new OrderDetail()
            {
                Id = 3,
                OrderID = 3,
                ProductId = 101,
                Price = 20000,
                Quantity = 2,
            },
            new OrderDetail()
            {
                Id = 4,
                OrderID = 4,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 5,
                OrderID = 5,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 6,
                OrderID = 6,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 7,
                OrderID = 7,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 8,
                OrderID = 8,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 9,
                OrderID = 9,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 10,
                OrderID = 10,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 11,
                OrderID = 11,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 12,
                OrderID = 12,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 13,
                OrderID = 13,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 14,
                OrderID = 14,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 15,
                OrderID = 15,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 16,
                OrderID = 16,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 17,
                OrderID = 17,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 18,
                OrderID = 18,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 19,
                OrderID = 19,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 20,
                OrderID = 20,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 21,
                OrderID = 21,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 22,
                OrderID = 22,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 23,
                OrderID = 23,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 24,
                OrderID = 24,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 25,
                OrderID = 25,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 26,
                OrderID = 26,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 27,
                OrderID = 27,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 28,
                OrderID = 28,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 29,
                OrderID = 29,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 30,
                OrderID = 30,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 31,
                OrderID = 31,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 32,
                OrderID = 32,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 33,
                OrderID = 33,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 34,
                OrderID = 34,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 35,
                OrderID = 35,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 36,
                OrderID = 36,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 37,
                OrderID = 37,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 38,
                OrderID = 38,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 39,
                OrderID = 39,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 40,
                OrderID = 40,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 41,
                OrderID = 41,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 42,
                OrderID = 42,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 43,
                OrderID = 43,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 44,
                OrderID = 44,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 45,
                OrderID = 45,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 46,
                OrderID = 46,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id =47,
                OrderID = 47,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 48,
                OrderID = 48,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 49,
                OrderID = 49,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 50,
                OrderID = 50,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 51,
                OrderID = 51,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 52,
                OrderID = 52,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 53,
                OrderID = 53,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 54,
                OrderID = 54,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 55,
                OrderID = 55,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 56,
                OrderID = 56,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 57,
                OrderID = 57,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 58,
                OrderID = 58,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 59,
                OrderID = 59,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 60,
                OrderID = 60,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 61,
                OrderID = 61,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 62,
                OrderID = 62,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 63,
                OrderID = 63,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 64,
                OrderID = 64,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 65,
                OrderID = 65,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 66,
                OrderID = 66,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 67,
                OrderID = 67,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 68,
                OrderID = 68,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 69,
                OrderID = 69,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 70,
                OrderID = 70,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 71,
                OrderID = 71,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 72,
                OrderID = 72,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 73,
                OrderID = 73,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 74,
                OrderID = 74,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 75,
                OrderID = 75,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 76,
                OrderID = 76,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 77,
                OrderID = 77,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 78,
                OrderID = 78,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 79,
                OrderID = 79,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 80,
                OrderID = 80,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 81,
                OrderID = 81,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 82,
                OrderID = 82,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 83,
                OrderID = 83,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 84,
                OrderID = 84,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 85,
                OrderID = 85,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 86,
                OrderID = 86,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 87,
                OrderID = 87,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 88,
                OrderID = 88,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 89,
                OrderID = 89,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 90,
                OrderID = 90,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 91,
                OrderID = 91,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 92,
                OrderID = 92,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 93,
                OrderID = 93,
                ProductId = 113,
                Price = 13000,
                Quantity = 1,
            }, new OrderDetail()
            {
                Id = 94,
                OrderID = 94,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 95,
                OrderID = 95,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 96,
                OrderID = 96,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 97,
                OrderID = 97,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 98,
                OrderID = 98,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 99,
                OrderID = 99,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 100,
                OrderID = 100,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 101,
                OrderID = 100,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 102,
                OrderID = 100,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 103,
                OrderID = 99,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 104,
                OrderID = 98,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 105,
                OrderID = 98,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 106,
                OrderID = 98,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 107,
                OrderID = 97,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 108,
                OrderID = 95,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 109,
                OrderID = 96,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 110,
                OrderID = 96,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 111,
                OrderID = 95,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 112,
                OrderID = 94,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 113,
                OrderID = 93,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 114,
                OrderID = 92,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 115,
                OrderID = 91,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 116,
                OrderID = 91,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 117,
                OrderID = 90,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 118,
                OrderID = 90,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 119,
                OrderID = 89,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 120,
                OrderID = 88,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 121,
                OrderID = 88,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 122,
                OrderID = 88,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 123,
                OrderID = 85,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 124,
                OrderID = 81,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 125,
                OrderID = 81,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 126,
                OrderID = 80,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 127,
                OrderID = 80,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 128,
                OrderID = 76,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 129,
                OrderID = 73,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 130,
                OrderID = 73,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 131,
                OrderID = 73,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 132,
                OrderID = 70,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 133,
                OrderID = 70,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 134,
                OrderID = 68,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 135,
                OrderID = 67,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 136,
                OrderID = 66,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 137,
                OrderID = 66,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 138,
                OrderID = 64,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 139,
                OrderID = 63,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 140,
                OrderID = 63,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 141,
                OrderID = 63,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 142,
                OrderID = 60,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 143,
                OrderID = 59,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 144,
                OrderID = 59,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 145,
                OrderID = 59,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 146,
                OrderID = 59,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 146,
                OrderID = 59,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 147,
                OrderID = 58,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 148,
                OrderID = 56,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 149,
                OrderID = 56,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 150,
                OrderID = 54,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 151,
                OrderID = 53,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 152,
                OrderID = 50,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 153,
                OrderID = 50,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 154,
                OrderID = 50,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 155,
                OrderID = 50,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 156,
                OrderID = 47,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 157,
                OrderID = 46,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 158,
                OrderID = 46,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 159,
                OrderID = 43,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 160,
                OrderID = 42,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 161,
                OrderID = 42,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 162,
                OrderID = 42,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 163,
                OrderID = 40,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 164,
                OrderID = 40,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 165,
                OrderID = 38,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 166,
                OrderID = 37,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 167,
                OrderID = 34,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 168,
                OrderID = 33,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 169,
                OrderID = 33,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 170,
                OrderID = 33,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 171,
                OrderID = 33,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 170,
                OrderID = 31,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 171,
                OrderID = 30,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 172,
                OrderID = 30,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 173,
                OrderID = 30,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 174,
                OrderID = 30,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 175,
                OrderID = 29,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 176,
                OrderID = 29,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 177,
                OrderID = 26,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 178,
                OrderID = 25,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 179,
                OrderID = 25,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 180,
                OrderID = 24,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 181,
                OrderID = 20,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 182,
                OrderID = 20,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 183,
                OrderID = 18,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 184,
                OrderID = 17,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 185,
                OrderID = 17,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 186,
                OrderID = 16,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 187,
                OrderID = 14,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 188,
                OrderID = 11,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 189,
                OrderID = 10,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 190,
                OrderID = 10,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 191,
                OrderID = 10,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 192,
                OrderID = 7,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 193,
                OrderID = 6,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 194,
                OrderID = 6,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 195,
                OrderID = 5,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 196,
                OrderID = 4,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19
            }, new OrderDetail()
            {
                Id = 197,
                OrderID = 4,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 198,
                OrderID = 2,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 199,
                OrderID = 1,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 200,
                OrderID = 1,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            });

        }
    }
}
