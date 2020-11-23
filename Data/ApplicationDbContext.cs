using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CellphoneStore.Models;

namespace CellphoneStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<HeDieuHanh> HeDieuHanhs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DeliveryCost> DeliveryCosts { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Supplier>().HasData(
                new Supplier { supplier_ID = 1, supplier_Name = "FPT Telecom" },
                new Supplier { supplier_ID = 2, supplier_Name = "Thế Giới Di Động" }
            );

            builder.Entity<Brand>().HasData(
                new Brand { brand_ID = 1, brand_Name = "Apple" },
                new Brand { brand_ID = 2, brand_Name = "Samsung" },
                new Brand { brand_ID = 3, brand_Name = "Xiaomi" },
                new Brand { brand_ID = 4, brand_Name = "Oppo" }
            );

            builder.Entity<Categories>().HasData(
                new Categories { categories_ID = 1, categories_Name = "Điện thoại" },
                new Categories { categories_ID = 2, categories_Name = "Phụ kiện" }
            );

            builder.Entity<HeDieuHanh>().HasData(
                new HeDieuHanh { hdh_ID = 1, hdh_Name = "iOS" },
                new HeDieuHanh { hdh_ID = 2, hdh_Name = "Android" }
            );

            builder.Entity<Promotion>().HasData(
                new Promotion { promotion_ID = 1, promotion_Name = "Giảm 10% cho sản phẩm", promotion_Percent = 10 },
                new Promotion { promotion_ID = 2, promotion_Name = "Giảm 15% đơn hàng", promotion_Percent = 15 },
                new Promotion { promotion_ID = 3, promotion_Name = "Giảm 50% cho mỗi đơn hàng", promotion_Percent = 50 }
            );

            builder.Entity<DeliveryCost>().HasData(
                new DeliveryCost { deliverycost_ID = 1, deliverycost_AreaName = "Quận 1", deliverycost_Cost = 15000 },
                new DeliveryCost { deliverycost_ID = 2, deliverycost_AreaName = "Quận 2", deliverycost_Cost = 15000 },
                new DeliveryCost { deliverycost_ID = 3, deliverycost_AreaName = "Quận 3", deliverycost_Cost = 10000 },
                new DeliveryCost { deliverycost_ID = 4, deliverycost_AreaName = "Quận 4", deliverycost_Cost = 30000 },
                new DeliveryCost { deliverycost_ID = 5, deliverycost_AreaName = "Ngoại thành", deliverycost_Cost = 50000 },
                new DeliveryCost { deliverycost_ID = 6, deliverycost_AreaName = "Miền Bắc", deliverycost_Cost = 100000 }
            );

            builder.Entity<Product>().HasData(
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =},
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =},
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =},
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =},
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =},
                new Product { product_ID =, product_Name = "", product_Price =, product_Quantity =, product_Image = "", product_Description = "", supplier_ID =, hdh_ID =, brand_ID =}
            );
        }
    }
}
