
using Microsoft.EntityFrameworkCore;
using OfficeEntityApp.Models;

public class Program
{
    public static void Main()
    {
        using (var context = new OfficeDbContext())
        {
            string employeeName = "Ravi Gupta";

            // Retrieve and display employee info
            var employee = context.Employees.Include(e => e.Department).FirstOrDefault(e => e.Name == employeeName);
            if(employee != null)
            {
                Console.WriteLine($"Employee: {employee.Name}, Department: {employee.Department.Name}");
            }
            else
            {
                Console.WriteLine("Employee with name '{employeeName}' not found.");
            }
        }
    }
}