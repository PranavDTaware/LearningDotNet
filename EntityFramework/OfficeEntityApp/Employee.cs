namespace OfficeEntityApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }  // Primary Key
        public string Name { get; set; }
        // Foreign Key
        public int Dept_Id { get; set; }
        // Navigation Property
        public Department Department { get; set; }
    }
}