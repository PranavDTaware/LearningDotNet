
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace WebApi.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Username { get; set; }
        [JsonIgnore]
        public string Password { get; set; }

        // Foreign key for Role
        public int RoleId { get; set; } // Add this property as a foreign key to the Role table
        [NotMapped]
        public Role Role { get; set; } // Navigation property to the Role
        
        public string Token { get; set; }
    }
}