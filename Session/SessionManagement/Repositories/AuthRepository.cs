using Core.Models;
using Core.Repositories;
using Core.Repositories.Interfaces;
using SessionManagement.Models;

namespace Core.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public bool Validate(string username, string password)
        {
            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == username);
                return user != null && user.Password == password;
            }
        }
        public void Insert(User register)
        {
            using (var context = new RepoCollectionContext())
            if (register.Id == 0)
            {
                context.Users.Add(register);
                context.SaveChanges();
            }
        }
    }
}
