using Microsoft.Extensions.Configuration;  // Ensure you have this namespace for IConfiguration
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Services
{
    public class UserService : IUserService
    {
        // users hardcoded for simplicity,
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Ganesh", LastName = "Shinde", Username = "ganesh", Password = "test" },
            new User { Id = 2, FirstName = "Ankur", LastName = "Prasad", Username = "ankur", Password = "test" },
            new User { Id = 3, FirstName = "Neha", LastName = "Bhor", Username = "neha", Password = "test" },
            new User { Id = 4, FirstName = "Vishwambhar", LastName = "Kapre", Username = "vishwambhar", Password = "test" }
        };

        private readonly IConfiguration _configuration;
        private readonly AppSettings _appSettings;

        public UserService(IConfiguration configuration, IOptions<AppSettings> appSettings)
        {
            _configuration = configuration;
            _appSettings = appSettings.Value;
        }

        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

            if (user == null) 
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }

        public IEnumerable<User> GetAll()
        {
            return _users.WithoutPasswords();
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
