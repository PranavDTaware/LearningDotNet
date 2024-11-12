using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace: logical collection of .NET types
namespace CRM
{
    public class Customer
    {
        public string UserId { get; set; } //Auto property
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string Location { get; set; }
    }
}
