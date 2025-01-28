using Core.Models;
using SessionManagement.Models;

namespace Core.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        bool Validate(string username, string password);
        void Insert(User register);
    }
}