using Core.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SessionManagement.Models;


namespace Core.Repositories
{
    public class RepoCollectionContext:DbContext
    {
        public DbSet<Flower> Flowers {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Fruit> Fruits{get;set;}
        public DbSet<User> Users{get;set;}
        public DbSet<Payment> Payments{get;set;}
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

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.OrderDate).IsRequired();
                entity.Property(e => e.Status).IsRequired();
                entity.Property(e => e.TotalAmount).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.UserName).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.PhoneNumber).IsRequired();
                entity.Property(e => e.Location).IsRequired();
            });

            modelBuilder.Entity<Payment>(entity => 
            {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PaymentDate).IsRequired();
            entity.Property(e => e.Amount).IsRequired();
            entity.Property(e => e.OrderId).IsRequired();
            entity.Property(e => e.PaymentMode).IsRequired();
            });
        }
    }
}