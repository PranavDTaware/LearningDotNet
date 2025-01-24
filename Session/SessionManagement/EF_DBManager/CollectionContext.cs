using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace EntityTestApp
{
    public class CollectionContext:DbContext
    {
        public DbSet<Product> Products {get;set;}

        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string conString = "server=localhost;user=root;database=onlineShopping;password='Senetor@2001'";
             optionsBuilder.UseMySql(conString,ServerVersion.AutoDetect(conString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });

            
        }
    }
}