using Microsoft.EntityFrameworkCore;
using OfficeEntityApp.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

public class OfficeDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = "server=localhost;user=root;database=office;password='Senetor@2001'";
        optionsBuilder.UseMySql(conString,ServerVersion.AutoDetect(conString));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)          // Employee has one Department
            .WithMany(d => d.Employees)         // Department has many Employees
            .HasForeignKey(e => e.Dept_Id)      // Foreign key in Employee
            .OnDelete(DeleteBehavior.Cascade);  // Define behavior on delete, e.g., cascade delete
    }
}