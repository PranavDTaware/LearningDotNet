using Core.Models;
using SessionManagement.Models;

namespace Core.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        bool Validate(string username, string password);
        void Register(User register);
        public User ForgotPassword(string username, string newPassword, string confirmPassword);
    }
}