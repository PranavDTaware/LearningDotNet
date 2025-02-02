namespace OfficeEntityApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }  // Primary Key
        public string Name { get; set; }
        // Navigation Property
        public ICollection<Employee> Employees { get; set; }
    }
}