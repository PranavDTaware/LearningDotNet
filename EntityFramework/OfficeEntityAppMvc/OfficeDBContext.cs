using Microsoft.EntityFrameworkCore;
using OfficeEntityApp.Models;

public class OfficeDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public OfficeDbContext(DbContextOptions<OfficeDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.Dept_Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}