namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using T1809E.SEM3.P102_Team05.Models;

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
                CreatedAt = DateTime.Parse("01/03/2019"),
                InStock = 1,
                Status= ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 2,
                Name = "Bàn Chải",
                Thumbnail = "https://phugiatrading.com/wp-content/uploads/2019/02/ban-chai-danh-rang-han-quoc-bio-care-crystal-nano-gold-1001g-2-1.jpg",
                Price = 15000,
                CreatedAt = DateTime.Parse("12/03/2019"),
                InStock = 2,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 3,
                Name = "Dầu Gội",
                Thumbnail = "https://depcosmetics.vn/wp-content/uploads/2017/01/8934868113652_1.jpg",
                Price = 65000,
                CreatedAt = DateTime.Parse("3/02/2019"),
                InStock = 3,
                Status = ProductStatus.DISABLE
            }, new Product()
            {
                Id = 4,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreatedAt = DateTime.Parse("4/01/2019"),
                InStock = 4,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 5,
                Name = "Áo Len",
                Thumbnail = "https://bizweb.dktcdn.net/100/107/464/files/9498404712-307052022.jpg?v=1564733482956",
                Price = 105000,
                CreatedAt = DateTime.Parse("08/04/2019"),
                InStock = 3,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 6,
                Name = "Áo Sơ Mi",
                Thumbnail = "https://salt.tikicdn.com/cache/550x550/ts/product/8e/4d/53/27b355f238f46235c9fefcd07a1cfd0e.jpg",
                Price = 75000,
                CreatedAt = DateTime.Parse("4/05/2019"),
                InStock = 4,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 7,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreatedAt = DateTime.Parse("3/06/2019"),
                InStock = 4,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 8,
                Name = "Quần Jean",
                Thumbnail = "https://vn-live-03.slatic.net/original/7efdce91f32f7004c953ddc8a22216d4.jpg",
                Price = 135000,
                CreatedAt = DateTime.Parse("2/08/2019"),
                InStock = 19,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 9,
                Name = "Áo Khoác nam",
                Thumbnail = "https://bizweb.dktcdn.net/thumb/large/100/180/420/products/750x750-1-1.jpg",
                Price = 225000,
                CreatedAt = DateTime.Parse("01/09/2019"),
                InStock = 40,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 10,
                Name = "Áo khoác nữ",
                Thumbnail = "https://quanaogiaxuong.com/wp-content/uploads/8947-clean-z1437963267757-960adcd8edf1993390eb7cec2fc8f9dc.jpg",
                Price = 235000,
                CreatedAt = DateTime.Parse("2/10/2019"),
                InStock = 4,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 11,
                Name = "Áo phông nam",
                Thumbnail = "https://shopmc.vn/wp-content/uploads/2017/03/Ao-phong-BHGaming-Minecraft.jpg",
                Price = 55000,
                CreatedAt = DateTime.Parse("4/07/2019"),
                InStock = 70,
                Status = ProductStatus.SOLD
            },
            new Product()
            {
                Id = 12,
                Name = "Áo phông nữ",
                Thumbnail = "https://kenhphunu.com/media/10204/1559754000/ao_phong_trang.jpg",
                Price = 55000,
                CreatedAt = DateTime.Parse("4/12/2019"),
                InStock = 80,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 13,
                Name = "quần Baggy",
                Thumbnail = "https://nocturnal.vn/wp-content/uploads/2019/09/3-600x600.jpg",
                Price = 115000,
                CreatedAt = DateTime.Parse("4/01/2018"),
                InStock = 100,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 14,
                Name = "Áo Hoodie",
                Thumbnail = "https://media3.scdn.vn/img3/2019/11_2/SQIy05_simg_de2fe0_500x500_maxb.jpg",
                Price = 135000,
                CreatedAt = DateTime.Parse("07/01/2018"),
                InStock = 80,
                Status = ProductStatus.SOLD
            },
            new Product()
            {
                Id = 15,
                Name = "Áo Thun nữ",
                Thumbnail = "https://aothuntrongiasi.com/wp-content/uploads/2018/04/ao-thun-trang-nu-1.jpg",
                Price = 75000,
                CreatedAt = DateTime.Parse("02/02/2018"),
                InStock = 110,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 16,
                Name = "quần short nam",
                Thumbnail = "https://img.zanado.com/media/catalog/product/cache/all/thumbnail/360x420/7b8fef0172c2eb72dd8fd366c999954c/7/_/quan_short_nam_tron_pa_e7c5.jpg",
                Price = 95000,
                CreatedAt = DateTime.Parse("7/03/2018"),
                InStock = 60,
                Status = ProductStatus.DELETED
            },
            new Product()
            {
                Id = 17,
                Name = "Quần áo thể thao",
                Thumbnail = "https://media3.scdn.vn/img2/2018/5_3/bdEfl8_simg_de2fe0_500x500_maxb.jpg",
                Price = 125000,
                CreatedAt = DateTime.Parse("4/02/2018"),
                InStock = 140,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 18,
                Name = "Áo dạ nam",
                Thumbnail = "https://media3.scdn.vn/img3/2019/10_3/eDADlp_simg_de2fe0_500x500_maxb.png",
                Price = 450000,
                CreatedAt = DateTime.Parse("08/03/2018"),
                InStock = 10,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 19,
                Name = "Áo dạ nữ",
                Thumbnail = "https://media3.scdn.vn/img3/2018/12_22/tXJbuH_simg_de2fe0_500x500_maxb.jpg",
                Price = 455000,
                CreatedAt = DateTime.Parse("5/03/2018"),
                InStock = 17,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 20,
                Name = "Áo Phao",
                Thumbnail = "https://dosityna.com/wp-content/uploads/2019/01/ao-phao-dep.jpg",
                Price = 355000,
                CreatedAt = DateTime.Parse("10/04/2018"),
                InStock = 30,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 21,
                Name = "Quần jogger nam",
                Thumbnail = "https://quanjogger.vn/image/cache/catalog/quanjoggernam/kaki/500-620-quan-jogger-nam-xam-tieu-avatar-500x620.jpg",
                Price = 85000,
                CreatedAt = DateTime.Parse("4/04/2018"),
                InStock = 190,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 22,
                Name = "quần jogger nữ",
                Thumbnail = "https://ann.com.vn/wp-content/uploads/11017-clean-857494ffd81821467809.jpg",
                Price = 85000,
                CreatedAt = DateTime.Parse("02/04/2018"),
                InStock = 180,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 23,
                Name = "Áo sơ mi caro",
                Thumbnail = "https://file.hstatic.net/1000401164/file/ao-so-mi-nam-thoi-trang-mando-1_d129dc6d1a28427ead3f29bbb81d2225_grande.jpg",
                Price = 125000,
                CreatedAt = DateTime.Parse("2/01/2018"),
                InStock = 240,
                Status = ProductStatus.SOLD
            },
            new Product()
            {
                Id = 24,
                Name = "Áo len dài tay",
                Thumbnail = "https://vcdn-ngoisao.vnecdn.net/2018/12/21/Ao-len-dai-tay-nam-Aristino-AW-3796-5251-1545389942.jpg",
                Price = 145000,
                CreatedAt = DateTime.Parse("09/03/2018"),
                InStock = 120,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 25,
                Name = "Váy len",
                Thumbnail = "https://media3.scdn.vn/img2/2018/9_14/s52GxR_simg_de2fe0_500x500_maxb.jpg",
                Price = 95000,
                CreatedAt = DateTime.Parse("1/4/2018"),
                InStock = 48,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 26,
                Name = "Quần vải nam",
                Thumbnail = "https://ragus.vn/wp-content/uploads/2019/04/Qu%E1%BA%A7n-V%E1%BA%A3i-Nam-Woven-%C4%91en-QV125007-2.jpg",
                Price = 125000,
                CreatedAt = DateTime.Parse("01/05/2018"),
                InStock = 63,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 27,
                Name = "Quần áo cho bé",
                Thumbnail = "https://thoitrang.biz/wp-content/uploads/2014/12/bo-ao-lien-quan-hinh-thu-de-thuong-cho-cac-be-1.jpg",
                Price = 90000,
                CreatedAt = DateTime.Parse("02/05/2018"),
                InStock = 54,
                Status = ProductStatus.ACTIVE
            },
            new Product()
            {
                Id = 28,
                Name = "Quần áo thun",
                Thumbnail = "https://www.bexinhshop.vn/image/data/17-1-2019/setdaydeonoCARO.jpg",
                Price = 120000,
                CreatedAt = DateTime.Parse("11/04/2018"),
                InStock = 23,
                Status = ProductStatus.DISABLE
            },
            new Product()
            {
                Id = 29,
                Name = "Áo thu đông",
                Thumbnail = "https://mjumju.net/wp-content/uploads/2017/12/ao-thu-dong-nam-TD014-3.jpg",
                Price = 100000,
                CreatedAt = DateTime.Parse("12/04/2018"),
                InStock = 61,
                Status = ProductStatus.SOLD
            },
            new Product()
            {
                Id = 30,
                Name = "Áo nỉ nam",
                Thumbnail = "https://linhvnxk.com/wp-content/uploads/2018/10/ao-ni-nam-xuat-han-tran-tram-15.jpg",
                Price = 115000,
                CreatedAt = DateTime.Parse("01/05/2018"),
                InStock = 89,
                Status = ProductStatus.DISABLE
            });
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE OrderDetails");
            context.OrderDetails.AddOrUpdate(new OrderDetail()
            {
                Id = 1,
                OrderId=1,
                ProductId=101,
                Price=20000,
                Quantity=2,
            },
            new OrderDetail()
            {
                Id = 2,
                OrderId = 2,
                ProductId = 101,
                Price = 20000,
                Quantity = 2,
            },
            new OrderDetail()
            {
                Id = 3,
                OrderId = 3,
                ProductId = 101,
                Price = 20000,
                Quantity = 2,
            },
            new OrderDetail()
            {
                Id = 4,
                OrderId = 4,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 5,
                OrderId = 5,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 6,
                OrderId = 6,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 7,
                OrderId = 7,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 8,
                OrderId = 8,
                ProductId = 102,
                Price = 303000,
                Quantity = 5,
            },
            new OrderDetail()
            {
                Id = 9,
                OrderId = 9,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 10,
                OrderId = 10,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 11,
                OrderId = 11,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 12,
                OrderId = 12,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 13,
                OrderId = 13,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 14,
                OrderId = 14,
                ProductId = 103,
                Price = 13000,
                Quantity = 1,
            },
            new OrderDetail()
            {
                Id = 15,
                OrderId = 15,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 16,
                OrderId = 16,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 17,
                OrderId = 17,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 18,
                OrderId = 18,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            },
            new OrderDetail()
            {
                Id = 19,
                OrderId = 19,
                ProductId = 104,
                Price = 250000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 20,
                OrderId = 20,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 21,
                OrderId = 21,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 22,
                OrderId = 22,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 23,
                OrderId = 23,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 24,
                OrderId = 24,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 25,
                OrderId = 25,
                ProductId = 105,
                Price = 1240000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 26,
                OrderId = 26,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 27,
                OrderId = 27,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 28,
                OrderId = 28,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 29,
                OrderId = 29,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 30,
                OrderId = 30,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 31,
                OrderId = 31,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 32,
                OrderId = 32,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 33,
                OrderId = 33,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 34,
                OrderId = 34,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 35,
                OrderId = 35,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 36,
                OrderId = 36,
                ProductId = 106,
                Price = 1440000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 37,
                OrderId = 37,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 38,
                OrderId = 38,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 39,
                OrderId = 39,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 40,
                OrderId = 40,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 41,
                OrderId = 41,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 42,
                OrderId = 42,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 43,
                OrderId = 43,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 44,
                OrderId = 44,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 45,
                OrderId = 45,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id = 46,
                OrderId = 46,
                ProductId = 107,
                Price = 1340000,
                Quantity = 10,
            }, new OrderDetail()
            {
                Id =47,
                OrderId = 47,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 48,
                OrderId = 48,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 49,
                OrderId = 49,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 50,
                OrderId = 50,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 51,
                OrderId = 51,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 52,
                OrderId = 52,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 53,
                OrderId = 53,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 54,
                OrderId = 54,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 55,
                OrderId = 55,
                ProductId = 108,
                Price = 1320000,
                Quantity = 12,
            }, new OrderDetail()
            {
                Id = 56,
                OrderId = 56,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 57,
                OrderId = 57,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 58,
                OrderId = 58,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 59,
                OrderId = 59,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 60,
                OrderId = 60,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 61,
                OrderId = 61,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 62,
                OrderId = 62,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 63,
                OrderId = 63,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 64,
                OrderId = 64,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 65,
                OrderId = 65,
                ProductId = 109,
                Price = 1450000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 66,
                OrderId = 66,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 67,
                OrderId = 67,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 68,
                OrderId = 68,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 69,
                OrderId = 69,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 70,
                OrderId = 70,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 71,
                OrderId = 71,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 72,
                OrderId = 72,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 73,
                OrderId = 73,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 74,
                OrderId = 74,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 75,
                OrderId = 75,
                ProductId = 110,
                Price = 320000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 76,
                OrderId = 76,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 77,
                OrderId = 77,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 78,
                OrderId = 78,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 79,
                OrderId = 79,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 80,
                OrderId = 80,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 81,
                OrderId = 81,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 82,
                OrderId = 82,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 83,
                OrderId = 83,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 84,
                OrderId = 84,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 85,
                OrderId = 85,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 86,
                OrderId = 86,
                ProductId = 111,
                Price = 1320000,
                Quantity = 7,
            }, new OrderDetail()
            {
                Id = 87,
                OrderId = 87,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 88,
                OrderId = 88,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 89,
                OrderId = 89,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 90,
                OrderId = 90,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 91,
                OrderId = 91,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 92,
                OrderId = 92,
                ProductId = 112,
                Price = 1231000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 93,
                OrderId = 93,
                ProductId = 113,
                Price = 13000,
                Quantity = 1,
            }, new OrderDetail()
            {
                Id = 94,
                OrderId = 94,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 95,
                OrderId = 95,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 96,
                OrderId = 96,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 97,
                OrderId = 97,
                ProductId = 114,
                Price = 1130000,
                Quantity = 6,
            }, new OrderDetail()
            {
                Id = 98,
                OrderId = 98,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 99,
                OrderId = 99,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 100,
                OrderId = 100,
                ProductId = 115,
                Price = 1321000,
                Quantity = 9,
            }, new OrderDetail()
            {
                Id = 101,
                OrderId = 100,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 102,
                OrderId = 100,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 103,
                OrderId = 99,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 104,
                OrderId = 98,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 105,
                OrderId = 98,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 106,
                OrderId = 98,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 107,
                OrderId = 97,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 108,
                OrderId = 95,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 109,
                OrderId = 96,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 110,
                OrderId = 96,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 111,
                OrderId = 95,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 112,
                OrderId = 94,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 113,
                OrderId = 93,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 114,
                OrderId = 92,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 115,
                OrderId = 91,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 116,
                OrderId = 91,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 117,
                OrderId = 90,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 118,
                OrderId = 90,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 119,
                OrderId = 89,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 120,
                OrderId = 88,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 121,
                OrderId = 88,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 122,
                OrderId = 88,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 123,
                OrderId = 85,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 124,
                OrderId = 81,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 125,
                OrderId = 81,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 126,
                OrderId = 80,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 127,
                OrderId = 80,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 128,
                OrderId = 76,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 129,
                OrderId = 73,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 130,
                OrderId = 73,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 131,
                OrderId = 73,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 132,
                OrderId = 70,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 133,
                OrderId = 70,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 134,
                OrderId = 68,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 135,
                OrderId = 67,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 136,
                OrderId = 66,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 137,
                OrderId = 66,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 138,
                OrderId = 64,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 139,
                OrderId = 63,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 140,
                OrderId = 63,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 141,
                OrderId = 63,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 142,
                OrderId = 60,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 143,
                OrderId = 59,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 144,
                OrderId = 59,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 145,
                OrderId = 59,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 146,
                OrderId = 59,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 146,
                OrderId = 59,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 147,
                OrderId = 58,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 148,
                OrderId = 56,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 149,
                OrderId = 56,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 150,
                OrderId = 54,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 151,
                OrderId = 53,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 152,
                OrderId = 50,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 153,
                OrderId = 50,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 154,
                OrderId = 50,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 155,
                OrderId = 50,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 156,
                OrderId = 47,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 157,
                OrderId = 46,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 158,
                OrderId = 46,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 159,
                OrderId = 43,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 160,
                OrderId = 42,
                ProductId = 117,
                Price = 3023000,
                Quantity = 14,
            }, new OrderDetail()
            {
                Id = 161,
                OrderId = 42,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 162,
                OrderId = 42,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 163,
                OrderId = 40,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 164,
                OrderId = 40,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 165,
                OrderId = 38,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 166,
                OrderId = 37,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 167,
                OrderId = 34,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 168,
                OrderId = 33,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 169,
                OrderId = 33,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 170,
                OrderId = 33,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 171,
                OrderId = 33,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 170,
                OrderId = 31,
                ProductId = 121,
                Price = 2349900,
                Quantity = 25,
            }, new OrderDetail()
            {
                Id = 171,
                OrderId = 30,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 172,
                OrderId = 30,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 173,
                OrderId = 30,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 174,
                OrderId = 30,
                ProductId = 126,
                Price = 520000,
                Quantity = 18,
            }, new OrderDetail()
            {
                Id = 175,
                OrderId = 29,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 176,
                OrderId = 29,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 177,
                OrderId = 26,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 178,
                OrderId = 25,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 179,
                OrderId = 25,
                ProductId = 130,
                Price = 112000,
                Quantity = 2,
            }, new OrderDetail()
            {
                Id = 180,
                OrderId = 24,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 181,
                OrderId = 20,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 182,
                OrderId = 20,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 183,
                OrderId = 18,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19,
            }, new OrderDetail()
            {
                Id = 184,
                OrderId = 17,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 185,
                OrderId = 17,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 186,
                OrderId = 16,
                ProductId = 128,
                Price = 1302000,
                Quantity = 21,
            }, new OrderDetail()
            {
                Id = 187,
                OrderId = 14,
                ProductId = 125,
                Price = 4321000,
                Quantity = 41,
            }, new OrderDetail()
            {
                Id = 188,
                OrderId = 11,
                ProductId = 123,
                Price = 140000,
                Quantity = 4,
            }, new OrderDetail()
            {
                Id = 189,
                OrderId = 10,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 190,
                OrderId = 10,
                ProductId = 129,
                Price = 1090000,
                Quantity = 24,
            }, new OrderDetail()
            {
                Id = 191,
                OrderId = 10,
                ProductId = 118,
                Price = 83000,
                Quantity = 3,
            }, new OrderDetail()
            {
                Id = 192,
                OrderId = 7,
                ProductId = 116,
                Price = 2230000,
                Quantity = 13,
            }, new OrderDetail()
            {
                Id = 193,
                OrderId = 6,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 194,
                OrderId = 6,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 195,
                OrderId = 5,
                ProductId = 122,
                Price = 540000,
                Quantity = 8,
            }, new OrderDetail()
            {
                Id = 196,
                OrderId = 4,
                ProductId = 119,
                Price = 1350000,
                Quantity = 19
            }, new OrderDetail()
            {
                Id = 197,
                OrderId = 4,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 198,
                OrderId = 2,
                ProductId = 124,
                Price = 981000,
                Quantity = 11,
            }, new OrderDetail()
            {
                Id = 199,
                OrderId = 1,
                ProductId = 120,
                Price = 1243500,
                Quantity = 15,
            }, new OrderDetail()
            {
                Id = 200,
                OrderId = 1,
                ProductId = 127,
                Price = 2231000,
                Quantity = 15,
            });
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
            },
            new Order()
            {
                OrderId=11,
                CustomerID=102,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2019-01-01"),
                UpdatedAt = DateTime.Parse("2019-01-02"),
                DeletedAt = DateTime.Parse("2019-02-03"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 12,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-02-11"),
                UpdatedAt = DateTime.Parse("2019-02-21"),
                DeletedAt = DateTime.Parse("2019-02-23"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 13,
                CustomerID = 104,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-02-13"),
                UpdatedAt = DateTime.Parse("2019-02-15"),
                DeletedAt = DateTime.Parse("2019-03-17"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 14,
                CustomerID = 105,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-7"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-05-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 15,
                CustomerID = 106,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2019-02-17"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-03-26"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 16,
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-07-17"),
                UpdatedAt = DateTime.Parse("2019-07-25"),
                DeletedAt = DateTime.Parse("2019-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 17,
                CustomerID = 107,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-17"),
                UpdatedAt = DateTime.Parse("2019-04-25"),
                DeletedAt = DateTime.Parse("2019-04-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 18,
                CustomerID = 108,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760000,
                CreatedAt = DateTime.Parse("2019-03-17"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-03-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 19,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-01-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 20,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 21,
                CustomerID = 102,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-02-13"),
                UpdatedAt = DateTime.Parse("2019-02-23"),
                DeletedAt = DateTime.Parse("2019-02-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 22,
                CustomerID = 103,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-05-13"),
                UpdatedAt = DateTime.Parse("2019-05-25"),
                DeletedAt = DateTime.Parse("2019-06-30"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 23,
                CustomerID = 104,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-12"),
                UpdatedAt = DateTime.Parse("2019-04-14"),
                DeletedAt = DateTime.Parse("2019-05-16"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 24,
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
                OrderId = 25,
                CustomerID = 206,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-03-17"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-04-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 26,
                CustomerID = 207,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-08-17"),
                UpdatedAt = DateTime.Parse("2019-08-25"),
                DeletedAt = DateTime.Parse("2019-08-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 27,
                CustomerID = 208,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2019-08-13"),
                UpdatedAt = DateTime.Parse("2019-08-23"),
                DeletedAt = DateTime.Parse("2019-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 28,
                CustomerID = 209,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 2600000,
                CreatedAt = DateTime.Parse("2019-09-13"),
                UpdatedAt = DateTime.Parse("2019-09-23"),
                DeletedAt = DateTime.Parse("2019-09-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 29,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-02-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=30,
                CustomerID=112,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2019-01-11"),
                UpdatedAt = DateTime.Parse("2019-01-12"),
                DeletedAt = DateTime.Parse("2019-02-13"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 31,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-03-11"),
                UpdatedAt = DateTime.Parse("2019-03-21"),
                DeletedAt = DateTime.Parse("2019-03-23"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 32,
                CustomerID = 124,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-12-13"),
                UpdatedAt = DateTime.Parse("2019-12-15"),
                DeletedAt = DateTime.Parse("2019-12-17"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 33,
                CustomerID = 125,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-04-12"),
                UpdatedAt = DateTime.Parse("2019-04-15"),
                DeletedAt = DateTime.Parse("2019-05-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 34,
                CustomerID = 126,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2019-03-17"),
                UpdatedAt = DateTime.Parse("2019-03-23"),
                DeletedAt = DateTime.Parse("2019-03-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 35
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-07-27"),
                UpdatedAt = DateTime.Parse("2019-07-28"),
                DeletedAt = DateTime.Parse("2019-07-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 36,
                CustomerID = 127,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-01-17"),
                UpdatedAt = DateTime.Parse("2019-01-25"),
                DeletedAt = DateTime.Parse("2019-01-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 37,
                CustomerID = 18,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2019-06-17"),
                UpdatedAt = DateTime.Parse("2019-06-25"),
                DeletedAt = DateTime.Parse("2019-06-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 38,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2019-02-17"),
                UpdatedAt = DateTime.Parse("2019-02-25"),
                DeletedAt = DateTime.Parse("2019-02-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 39,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-04-17"),
                UpdatedAt = DateTime.Parse("2019-04-25"),
                DeletedAt = DateTime.Parse("2019-05-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=40,
                CustomerID=112,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2019-02-11"),
                UpdatedAt = DateTime.Parse("2019-02-12"),
                DeletedAt = DateTime.Parse("2019-02-13"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 41,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2019-03-12"),
                UpdatedAt = DateTime.Parse("2019-03-22"),
                DeletedAt = DateTime.Parse("2019-03-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 42,
                CustomerID = 124,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2019-12-11"),
                UpdatedAt = DateTime.Parse("2019-12-12"),
                DeletedAt = DateTime.Parse("2019-12-15),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 43,
                CustomerID = 125,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-07-12"),
                UpdatedAt = DateTime.Parse("2019-07-15"),
                DeletedAt = DateTime.Parse("2019-08-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 44,
                CustomerID = 126,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2019-02-17"),
                UpdatedAt = DateTime.Parse("2019-02-23"),
                DeletedAt = DateTime.Parse("2019-02-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 45
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2019-08-27"),
                UpdatedAt = DateTime.Parse("2019-08-28"),
                DeletedAt = DateTime.Parse("2019-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 46,
                CustomerID = 147,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2019-09-17"),
                UpdatedAt = DateTime.Parse("2019-09-25"),
                DeletedAt = DateTime.Parse("2019-09-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 47,
                CustomerID = 18,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2019-06-17"),
                UpdatedAt = DateTime.Parse("2019-06-19"),
                DeletedAt = DateTime.Parse("2019-06-20"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 48,
                CustomerID = 19,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2019-03-17"),
                UpdatedAt = DateTime.Parse("2019-03-25"),
                DeletedAt = DateTime.Parse("2019-03-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 49,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2019-04-17"),
                UpdatedAt = DateTime.Parse("2019-04-25"),
                DeletedAt = DateTime.Parse("2019-05-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=50,
                CustomerID=101,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2020-01-17"),
                UpdatedAt = DateTime.Parse("2020-01-25"),
                DeletedAt = DateTime.Parse("2020-02-29"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 51,
                CustomerID = 102,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2020-02-17"),
                UpdatedAt = DateTime.Parse("2020-02-25"),
                DeletedAt = DateTime.Parse("2020-02-29"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 52,
                CustomerID = 103,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2020-03-13"),
                UpdatedAt = DateTime.Parse("2020-03-25"),
                DeletedAt = DateTime.Parse("2020-04-30"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 53,
                CustomerID = 104,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-04-17"),
                UpdatedAt = DateTime.Parse("2020-04-25"),
                DeletedAt = DateTime.Parse("2020-05-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 54,
                CustomerID = 105,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2020-05-17"),
                UpdatedAt = DateTime.Parse("2020-05-25"),
                DeletedAt = DateTime.Parse("2020-06-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 55,
                CustomerID = 106,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2020-06-17"),
                UpdatedAt = DateTime.Parse("2020-06-25"),
                DeletedAt = DateTime.Parse("2020-07-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId =56,
                CustomerID = 107,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-07-17"),
                UpdatedAt = DateTime.Parse("2020-07-25"),
                DeletedAt = DateTime.Parse("2020-08-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 57,
                CustomerID = 108,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760000,
                CreatedAt = DateTime.Parse("2020-08-17"),
                UpdatedAt = DateTime.Parse("2020-08-25"),
                DeletedAt = DateTime.Parse("2020-09-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 58,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2020-09-17"),
                UpdatedAt = DateTime.Parse("2020-09-25"),
                DeletedAt = DateTime.Parse("2020-10-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 59,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-01-07"),
                UpdatedAt = DateTime.Parse("2020-01-15"),
                DeletedAt = DateTime.Parse("2020-02-19"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=60,
                CustomerID=102,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2020-01-01"),
                UpdatedAt = DateTime.Parse("2020-01-02"),
                DeletedAt = DateTime.Parse("2020-02-03"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 61,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2020-02-11"),
                UpdatedAt = DateTime.Parse("2020-02-21"),
                DeletedAt = DateTime.Parse("2020-02-23"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 62,
                CustomerID = 104,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2020-02-13"),
                UpdatedAt = DateTime.Parse("2020-02-15"),
                DeletedAt = DateTime.Parse("2020-03-17"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 63,
                CustomerID = 105,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-04-7"),
                UpdatedAt = DateTime.Parse("2020-04-15"),
                DeletedAt = DateTime.Parse("2020-05-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 64,
                CustomerID = 106,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2020-02-17"),
                UpdatedAt = DateTime.Parse("2020-03-25"),
                DeletedAt = DateTime.Parse("2020-03-26"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 65,
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2020-07-17"),
                UpdatedAt = DateTime.Parse("2020-07-25"),
                DeletedAt = DateTime.Parse("2020-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 66,
                CustomerID = 107,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-04-17"),
                UpdatedAt = DateTime.Parse("2020-04-25"),
                DeletedAt = DateTime.Parse("2020-04-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 67,
                CustomerID = 108,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760000,
                CreatedAt = DateTime.Parse("2020-03-17"),
                UpdatedAt = DateTime.Parse("2020-03-25"),
                DeletedAt = DateTime.Parse("2020-03-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId =68,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2020-01-17"),
                UpdatedAt = DateTime.Parse("2020-01-25"),
                DeletedAt = DateTime.Parse("2020-01-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 69,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-01-17"),
                UpdatedAt = DateTime.Parse("2020-01-25"),
                DeletedAt = DateTime.Parse("2020-02-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 70,
                CustomerID = 102,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2020-02-13"),
                UpdatedAt = DateTime.Parse("2020-02-23"),
                DeletedAt = DateTime.Parse("2020-02-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 71,
                CustomerID = 103,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2020-05-13"),
                UpdatedAt = DateTime.Parse("2020-05-25"),
                DeletedAt = DateTime.Parse("2020-06-30"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 72,
                CustomerID = 104,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-04-12"),
                UpdatedAt = DateTime.Parse("2020-04-14"),
                DeletedAt = DateTime.Parse("2020-05-16"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 73,
                CustomerID = 105,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2020-05-17"),
                UpdatedAt = DateTime.Parse("2020-05-25"),
                DeletedAt = DateTime.Parse("2020-06-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 74,
                CustomerID = 206,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2020-03-17"),
                UpdatedAt = DateTime.Parse("2020-03-25"),
                DeletedAt = DateTime.Parse("2020-04-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 75,
                CustomerID = 207,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-08-17"),
                UpdatedAt = DateTime.Parse("2020-08-25"),
                DeletedAt = DateTime.Parse("2020-08-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 76,
                CustomerID = 208,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2020-08-13"),
                UpdatedAt = DateTime.Parse("2020-08-23"),
                DeletedAt = DateTime.Parse("2020-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 77,
                CustomerID = 209,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 2600000,
                CreatedAt = DateTime.Parse("2020-09-13"),
                UpdatedAt = DateTime.Parse("2020-09-23"),
                DeletedAt = DateTime.Parse("2020-09-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 78,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-01-17"),
                UpdatedAt = DateTime.Parse("2020-01-25"),
                DeletedAt = DateTime.Parse("2020-02-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=79,
                CustomerID=112,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2020-01-11"),
                UpdatedAt = DateTime.Parse("2020-01-12"),
                DeletedAt = DateTime.Parse("2020-02-13"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 80,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2020-03-11"),
                UpdatedAt = DateTime.Parse("2020-03-21"),
                DeletedAt = DateTime.Parse("2020-03-23"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 81,
                CustomerID = 124,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2020-12-13"),
                UpdatedAt = DateTime.Parse("2020-12-15"),
                DeletedAt = DateTime.Parse("2020-12-17"),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 82,
                CustomerID = 125,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-04-12"),
                UpdatedAt = DateTime.Parse("2020-04-15"),
                DeletedAt = DateTime.Parse("2020-05-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 83,
                CustomerID = 126,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2020-03-17"),
                UpdatedAt = DateTime.Parse("2020-03-23"),
                DeletedAt = DateTime.Parse("2020-03-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 84,
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2020-07-27"),
                UpdatedAt = DateTime.Parse("2020-07-28"),
                DeletedAt = DateTime.Parse("2020-07-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 85,
                CustomerID = 127,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-01-17"),
                UpdatedAt = DateTime.Parse("2020-01-25"),
                DeletedAt = DateTime.Parse("2020-01-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 86,
                CustomerID = 18,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2020-06-17"),
                UpdatedAt = DateTime.Parse("2020-06-25"),
                DeletedAt = DateTime.Parse("2020-06-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 87,
                CustomerID = 109,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2020-02-17"),
                UpdatedAt = DateTime.Parse("2020-02-25"),
                DeletedAt = DateTime.Parse("2020-02-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 88,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-04-17"),
                UpdatedAt = DateTime.Parse("2020-04-25"),
                DeletedAt = DateTime.Parse("2020-05-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId=89,
                CustomerID=112,
                OrderNumber=2,
                ShippingAddress= "HA NOI",
                Total=100000,
                CreatedAt = DateTime.Parse("2020-02-11"),
                UpdatedAt = DateTime.Parse("2020-02-12"),
                DeletedAt = DateTime.Parse("2020-02-13"),
                OrderStatus11.ACTIVE
            },new Order()
            {
                OrderId = 90,
                CustomerID = 103,
                OrderNumber = 5,
                ShippingAddress = "Ha Tinh",
                Total = 150000,
                CreatedAt = DateTime.Parse("2020-03-12"),
                UpdatedAt = DateTime.Parse("2020-03-22"),
                DeletedAt = DateTime.Parse("2020-03-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 91,
                CustomerID = 124,
                OrderNumber = 2,
                ShippingAddress = "Hai Duong",
                Total = 145000,
                CreatedAt = DateTime.Parse("2020-12-11"),
                UpdatedAt = DateTime.Parse("2020-12-12"),
                DeletedAt = DateTime.Parse("2020-12-15),
                OrderStatus1.DELETED
            }, new Order()
            {
                OrderId = 92,
                CustomerID = 125,
                OrderNumber = 1,
                ShippingAddress = "Vinh Phuc",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-07-12"),
                UpdatedAt = DateTime.Parse("2020-07-15"),
                DeletedAt = DateTime.Parse("2020-08-20"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 93,
                CustomerID = 126,
                OrderNumber = 5,
                ShippingAddress = "Ninh Binh",
                Total = 1400000,
                CreatedAt = DateTime.Parse("2020-02-17"),
                UpdatedAt = DateTime.Parse("2020-02-23"),
                DeletedAt = DateTime.Parse("2020-02-24"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 94
                CustomerID = 107,
                OrderNumber = 7,
                ShippingAddress = "Long An",
                Total = 1500000,
                CreatedAt = DateTime.Parse("2020-08-27"),
                UpdatedAt = DateTime.Parse("2020-08-28"),
                DeletedAt = DateTime.Parse("2020-08-30"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 95,
                CustomerID = 147,
                OrderNumber = 4,
                ShippingAddress = "Ha Long",
                Total = 100000,
                CreatedAt = DateTime.Parse("2020-09-17"),
                UpdatedAt = DateTime.Parse("2020-09-25"),
                DeletedAt = DateTime.Parse("2020-09-30"),
                OrderStatus1.ACTIVE
            }, new Order()
            {
                OrderId = 96,
                CustomerID = 18,
                OrderNumber = 5,
                ShippingAddress = "HA NOI",
                Total = 760020,
                CreatedAt = DateTime.Parse("2020-06-17"),
                UpdatedAt = DateTime.Parse("2020-06-19"),
                DeletedAt = DateTime.Parse("2020-06-20"),
                OrderStatus1.DISABLE
            }, new Order()
            {
                OrderId = 97,
                CustomerID = 19,
                OrderNumber = 18,
                ShippingAddress = "Hue",
                Total = 1600000,
                CreatedAt = DateTime.Parse("2020-03-17"),
                UpdatedAt = DateTime.Parse("2020-03-25"),
                DeletedAt = DateTime.Parse("2020-03-30"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 98,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-04-17"),
                UpdatedAt = DateTime.Parse("2020-04-25"),
                DeletedAt = DateTime.Parse("2020-04-29"),
                OrderStatus1.ACTIVE
            },
            new Order()
            {
                OrderId = 99,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-06-17"),
                UpdatedAt = DateTime.Parse("2020-06-25"),
                DeletedAt = DateTime.Parse("2020-06-29"),
                OrderStatus1.ACTIVEss
            },
            new Order()
            {
                OrderId = 100,
                CustomerID = 110,
                OrderNumber = 3,
                ShippingAddress = "Sai Gon",
                Total = 900000,
                CreatedAt = DateTime.Parse("2020-04-17"),
                UpdatedAt = DateTime.Parse("2020-04-25"),
                DeletedAt = DateTime.Parse("2020-04-29"),
                OrderStatus1.ACTIVE
            },

            );
        }
    }
}
