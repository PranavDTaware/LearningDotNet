using Core.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace Core.Repositories
{
    public class RepoCollectionContext:DbContext
    {
        public DbSet<Flower> Flowers {get;set;}
        
        public DbSet<Fruit> Fruits{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             string conString = "server=localhost;user=root;database=onlineShopping;password='Senetor@2001'";
             optionsBuilder.UseMySql(conString,ServerVersion.AutoDetect(conString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Flower>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });

            modelBuilder.Entity<Fruit>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.MovieName).IsRequired();
                entity.Property(e => e.SalePrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });
        }
    }
}