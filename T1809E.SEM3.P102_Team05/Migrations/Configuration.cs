namespace T1809E.SEM3.P102_Team05.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
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
                CreateAt = DateTime.Parse("2019-01-03"),
                UpdateAt = DateTime.Parse("2019-01-15"),
                DeleteAt = DateTime.Parse("2019-02-03"),
                InStock = 1,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 2,
                Name = "Bàn Chải",
                Thumbnail = "https://phugiatrading.com/wp-content/uploads/2019/02/ban-chai-danh-rang-han-quoc-bio-care-crystal-nano-gold-1001g-2-1.jpg",
                Price = 15000,
                CreateAt = DateTime.Parse("2019-01-04"),
                UpdateAt = DateTime.Parse("2019-01-16"),
                DeleteAt = DateTime.Parse("2019-02-04"),
                InStock = 2,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 3,
                Name = "Dầu Gội",
                Thumbnail = "https://depcosmetics.vn/wp-content/uploads/2017/01/8934868113652_1.jpg",
                Price = 65000,
                CreateAt = DateTime.Parse("2019-01-05"),
                UpdateAt = DateTime.Parse("2019-01-17"),
                DeleteAt = DateTime.Parse("2019-02-07"),
                InStock = 3,
                OrderStatus.DISABLED
            }, new Product()
            {
                Id = 4,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreateAt = DateTime.Parse("2019-01-03"),
                UpdateAt = DateTime.Parse("2019-01-18"),
                DeleteAt = DateTime.Parse("2019-02-06"),
                InStock = 4,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 5,
                Name = "Áo Len",
                Thumbnail = "https://bizweb.dktcdn.net/100/107/464/files/9498404712-307052022.jpg?v=1564733482956",
                Price = 105000,
                CreateAt = DateTime.Parse("2019-01-15"),
                UpdateAt = DateTime.Parse("2019-01-20"),
                DeleteAt = DateTime.Parse("2019-02-13"),
                InStock = 3,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 6,
                Name = "Áo Sơ Mi",
                Thumbnail = "https://salt.tikicdn.com/cache/550x550/ts/product/8e/4d/53/27b355f238f46235c9fefcd07a1cfd0e.jpg",
                Price = 75000,
                CreateAt = DateTime.Parse("2019-01-12"),
                UpdateAt = DateTime.Parse("2019-01-21"),
                DeleteAt = DateTime.Parse("2019-02-05"),
                InStock = 4,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 7,
                Name = "Dầu Rửa Bát",
                Thumbnail = "https://cdn.tgdd.vn/Products/Images/2387/76477/bhx/nuoc-rua-chen-my-hao-huong-chanh-38kg-201904181442402324.jpg",
                Price = 25000,
                CreateAt = DateTime.Parse("2019-01-03"),
                UpdateAt = DateTime.Parse("2019-01-25"),
                DeleteAt = DateTime.Parse("2019-02-23"),
                InStock = 4,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 8,
                Name = "Quần Jean",
                Thumbnail = "https://vn-live-03.slatic.net/original/7efdce91f32f7004c953ddc8a22216d4.jpg",
                Price = 135000,
                CreateAt = DateTime.Parse("2019-02-23"),
                UpdateAt = DateTime.Parse("2019-03-15"),
                DeleteAt = DateTime.Parse("2019-03-24"),
                InStock = 19,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 9,
                Name = "Áo Khoác nam",
                Thumbnail = "https://bizweb.dktcdn.net/thumb/large/100/180/420/products/750x750-1-1.jpg",
                Price = 225000,
                CreateAt = DateTime.Parse("2019-03-13"),
                UpdateAt = DateTime.Parse("2019-03-15"),
                DeleteAt = DateTime.Parse("2019-04-03"),
                InStock = 40,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 10,
                Name = "Áo khoác nữ",
                Thumbnail = "https://quanaogiaxuong.com/wp-content/uploads/8947-clean-z1437963267757-960adcd8edf1993390eb7cec2fc8f9dc.jpg",
                Price = 235000,
                CreateAt = DateTime.Parse("2019-01-17"),
                UpdateAt = DateTime.Parse("2019-01-25"),
                DeleteAt = DateTime.Parse("2019-02-30"),
                InStock = 4,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 11,
                Name = "Áo phông nam",
                Thumbnail = "https://shopmc.vn/wp-content/uploads/2017/03/Ao-phong-BHGaming-Minecraft.jpg",
                Price = 55000,
                CreateAt = DateTime.Parse("2020-01-01"),
                UpdateAt = DateTime.Parse("2020-01-03"),
                DeleteAt = DateTime.Parse("2020-02-05"),
                InStock = 70,
                OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 12,
                Name = "Áo phông nữ",
                Thumbnail = "https://kenhphunu.com/media/102015/1559754000/ao_phong_trang.jpg",
                Price = 55000,
                CreateAt = DateTime.Parse("2019-04-13"),
                UpdateAt = DateTime.Parse("2019-04-15"),
                DeleteAt = DateTime.Parse("2019-04-20"),
                InStock = 80,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 13,
                Name = "quần Baggy",
                Thumbnail = "https://nocturnal.vn/wp-content/uploads/2019/09/3-600x600.jpg",
                Price = 115000,
                CreateAt = DateTime.Parse("2019-04-15"),
                UpdateAt = DateTime.Parse("2019-04-19"),
                DeleteAt = DateTime.Parse("2019-05-27"),
                InStock = 100,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 14,
                Name = "Áo Hoodie",
                Thumbnail = "https://media3.scdn.vn/img3/2019/11_2/SQIy05_simg_de2fe0_500x500_maxb.jpg",
                Price = 135000,
                CreateAt = DateTime.Parse("2019-05-05"),
                UpdateAt = DateTime.Parse("2019-05-10"),
                DeleteAt = DateTime.Parse("2019-05-30"),
                InStock = 80,
                OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 15,
                Name = "Áo Thun nữ",
                Thumbnail = "https://aothuntrongiasi.com/wp-content/uploads/2018/04/ao-thun-trang-nu-1.jpg",
                Price = 75000,
                CreateAt = DateTime.Parse("2019-06-13"),
                UpdateAt = DateTime.Parse("2019-06-29"),
                DeleteAt = DateTime.Parse("2019-07-23"),
                InStock = 110,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 16,
                Name = "quần short nam",
                Thumbnail = "https://img.zanado.com/media/catalog/product/cache/all/thumbnail/360x420/7b8fef0172c2eb72dd8fd366c999954c/7/_/quan_short_nam_tron_pa_e7c5.jpg",
                Price = 95000,
                CreateAt = DateTime.Parse("2019-06-03"),
                UpdateAt = DateTime.Parse("2019-06-15"),
                DeleteAt = DateTime.Parse("2019-07-03"),
                InStock = 60,
                OrderStatus.DELETED
            },
            new Product()
            {
                Id = 17,
                Name = "Quần áo thể thao",
                Thumbnail = "https://media3.scdn.vn/img2/2018/5_3/bdEfl8_simg_de2fe0_500x500_maxb.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("2019-07-01"),
                UpdateAt = DateTime.Parse("2019-07-15"),
                DeleteAt = DateTime.Parse("2019-07-23"),
                InStock = 140,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 18,
                Name = "Áo dạ nam",
                Thumbnail = "https://media3.scdn.vn/img3/2019/10_3/eDADlp_simg_de2fe0_500x500_maxb.png",
                Price = 450000,
                CreateAt = DateTime.Parse("2019-07-13"),
                UpdateAt = DateTime.Parse("2019-08-29"),
                DeleteAt = DateTime.Parse("2019-09-03"),
                InStock = 10,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 19,
                Name = "Áo dạ nữ",
                Thumbnail = "https://media3.scdn.vn/img3/2018/12_22/tXJbuH_simg_de2fe0_500x500_maxb.jpg",
                Price = 455000,
                CreateAt = DateTime.Parse("2020-02-13"),
                UpdateAt = DateTime.Parse("2020-02-15"),
                DeleteAt = DateTime.Parse("2020-04-03"),
                InStock = 17,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 20,
                Name = "Áo Phao",
                Thumbnail = "https://dosityna.com/wp-content/uploads/2019/01/ao-phao-dep.jpg",
                Price = 355000,
                CreateAt = DateTime.Parse("2019-11-30"),
                UpdateAt = DateTime.Parse("2019-12-15"),
                DeleteAt = DateTime.Parse("2019-12-23"),
                InStock = 30,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 21,
                Name = "Quần jogger nam",
                Thumbnail = "https://quanjogger.vn/image/cache/catalog/quanjoggernam/kaki/500-620-quan-jogger-nam-xam-tieu-avatar-500x620.jpg",
                Price = 85000,
                CreateAt = DateTime.Parse("2019-10-13"),
                UpdateAt = DateTime.Parse("2019-10-18"),
                DeleteAt = DateTime.Parse("2019-10-23"),
                InStock = 190,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 22,
                Name = "quần jogger nữ",
                Thumbnail = "https://ann.com.vn/wp-content/uploads/11017-clean-857494ffd81821467809.jpg",
                Price = 85000,
                CreateAt = DateTime.Parse("2019-08-01"),
                UpdateAt = DateTime.Parse("2019-08-15"),
                DeleteAt = DateTime.Parse("2019-09-23"),
                InStock = 180,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 23,
                Name = "Áo sơ mi caro",
                Thumbnail = "https://file.hstatic.net/1000401164/file/ao-so-mi-nam-thoi-trang-mando-1_d129dc6d1a28427ead3f29bbb81d2225_grande.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("2020-02-06"),
                UpdateAt = DateTime.Parse("2020-02-07"),
                DeleteAt = DateTime.Parse("2020-04-03"),
                InStock = 240,
                OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 24,
                Name = "Áo len dài tay",
                Thumbnail = "https://vcdn-ngoisao.vnecdn.net/2018/12/21/Ao-len-dai-tay-nam-Aristino-AW-3796-5251-1545389942.jpg",
                Price = 145000,
                CreateAt = DateTime.Parse("2019-08-18"),
                UpdateAt = DateTime.Parse("2019-09-15"),
                DeleteAt = DateTime.Parse("2019-10-03"),
                InStock = 120,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 25,
                Name = "Váy len",
                Thumbnail = "https://media3.scdn.vn/img2/2018/9_14/s52GxR_simg_de2fe0_500x500_maxb.jpg",
                Price = 95000,
                CreateAt = DateTime.Parse("2020-02-13"),
                UpdateAt = DateTime.Parse("2020-03-15"),
                DeleteAt = DateTime.Parse("2020-04-03"),
                InStock = 48,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 26,
                Name = "Quần vải nam",
                Thumbnail = "https://ragus.vn/wp-content/uploads/2019/04/Qu%E1%BA%A7n-V%E1%BA%A3i-Nam-Woven-%C4%91en-QV125007-2.jpg",
                Price = 125000,
                CreateAt = DateTime.Parse("2020-02-23"),
                UpdateAt = DateTime.Parse("2020-03-29"),
                DeleteAt = DateTime.Parse("2020-04-17"),
                InStock = 63,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 27,
                Name = "Quần áo cho bé",
                Thumbnail = "https://thoitrang.biz/wp-content/uploads/2014/12/bo-ao-lien-quan-hinh-thu-de-thuong-cho-cac-be-1.jpg",
                Price = 90000,
                CreateAt = DateTime.Parse("2019-09-23"),
                UpdateAt = DateTime.Parse("2019-10-16"),
                DeleteAt = DateTime.Parse("2019-10-23"),
                InStock = 54,
                OrderStatus.ACTIVE
            },
            new Product()
            {
                Id = 28,
                Name = "Quần áo thun",
                Thumbnail = "https://www.bexinhshop.vn/image/data/17-1-2019/setdaydeonoCARO.jpg",
                Price = 120000,
                CreateAt = DateTime.Parse("2019-09-11"),
                UpdateAt = DateTime.Parse("2019-09-25"),
                DeleteAt = DateTime.Parse("2019-11-23"),
                InStock = 23,
                OrderStatus.DISABLED
            },
            new Product()
            {
                Id = 29,
                Name = "Áo thu đông",
                Thumbnail = "https://mjumju.net/wp-content/uploads/2017/12/ao-thu-dong-nam-TD014-3.jpg",
                Price = 100000,
                CreateAt = DateTime.Parse("2020-01-14"),
                UpdateAt = DateTime.Parse("2020-01-25"),
                DeleteAt = DateTime.Parse("2020-02-12"),
                InStock = 61,
                OrderStatus.OUT_OF_STOCK
            },
            new Product()
            {
                Id = 30,
                Name = "Áo nỉ nam",
                Thumbnail = "https://linhvnxk.com/wp-content/uploads/2018/10/ao-ni-nam-xuat-han-tran-tram-15.jpg",
                Price = 115000,
                CreateAt = DateTime.Parse("2019-12-13"),
                UpdateAt = DateTime.Parse("2020-01-15"),
                DeleteAt = DateTime.Parse("2020-02-03"),
                InStock = 89,
                OrderStatus.DISABLED
            });
        }
    }
}
