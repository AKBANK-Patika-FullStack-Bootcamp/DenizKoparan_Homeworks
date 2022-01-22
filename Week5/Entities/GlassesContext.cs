using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class GlassesContext : DbContext
    {
        public GlassesContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = localhost; Database = Glasses; integrated security = True;");
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<APIAuthority> APIAuthority { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Prices>().ToTable("Prices");
            modelBuilder.Entity<APIAuthority>().ToTable("APIAuthority");
        }

        public List<APIAuthority> GetUsers()
        {
            List<APIAuthority> users = new List<APIAuthority>();
            users = APIAuthority.ToList();

            return users;
        }

        public List<Brand> GetBrands()
        {
            List<Brand> brands = new List<Brand>();
            brands = Brand.ToList();

            return brands;
        }
    }
}
