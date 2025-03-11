namespace WebApi.Entities
{
    public class Role
    {
        public int Id { get; set; }          // Primary Key
        public string Name { get; set; }     // Role name (Admin, User, etc.)
        
        // Navigation property 
        public ICollection<User> Users { get; set; } = new List<User>();
        
        // Static Role Constants
        public const string Admin = "Admin";
        public const string User = "User";
        public const string Manager = "Manager";
        public const string Distributor = "Distributor";
        public const string Shopper = "Shopper";
    }
}
