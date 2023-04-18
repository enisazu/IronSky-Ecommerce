using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            optionsBuilder.UseSqlServer("Data Source=ENISA\\SQLEXPRESS;Initial Catalog=ECommerce;Integrated Security=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider>  Sliders { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}
