using Core.Models;
using Core.Repositories.Interfaces;
using Core.Services.Interfaces;

namespace Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepo;
        public AuthService(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        public bool Validate(string username, string password) => _authRepo.Validate(username,password);
        public void Register(User register) => _authRepo.Register(register);
        public User ForgotPassword(string username, string newPassword, string confirmPassword) => _authRepo.ForgotPassword(username, newPassword, confirmPassword);
    }
}
