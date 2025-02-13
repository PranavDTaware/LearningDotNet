using ProductsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace ProductsWebAPI.Context
{
    public class CollectionContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost;database=onlineShopping;user=root;password='Senetor@2001'";
            optionsBuilder.UseMySql(
                conString,
            ServerVersion.AutoDetect(conString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity => 
            {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.Description).IsRequired();
            entity.Property(e => e.UnitPrice).IsRequired();
            entity.Property(e => e.Quantity).IsRequired();
            });
        }
    }
}