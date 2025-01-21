using Microsoft.EntityFrameworkCore;
namespace Core.ORM
{
    public class CollectionContext:DbContext{

    public DbSet<Product> Products {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=actsdb; user=root; password=''";
        optionsBuilder.UseMySQL(conString);

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