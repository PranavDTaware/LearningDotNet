using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Entities;

public class JWAContext : DbContext
{
    public JWAContext(DbContextOptions<JWAContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }


    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     string conString = "server=localhost;user=root;database=HR;password='Senetor@2001'";
    //     optionsBuilder.UseMySql(conString, ServerVersion.AutoDetect(conString));
    // }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)                // User has one Role
            .WithMany(r => r.Users)        // Role has many Users
            .HasForeignKey(u => u.Role)    // Foreign key in User for Role
            .OnDelete(DeleteBehavior.SetNull); // Set to null if Role is deleted
        
        // You can configure any other relationships or constraints as needed.
    }
}
