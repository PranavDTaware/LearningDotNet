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
        public void Register(User register)
        {
            using (var context = new RepoCollectionContext())
                if (register.Id == 0)
                {
                    context.Users.Add(register);
                    context.SaveChanges();
                }
        }

        public User ForgotPassword(string username, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
            {
                return null;
            }

            using (var context = new RepoCollectionContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == username);

                if (user == null)
                {
                    return null;
                }

                user.Password = newPassword;
                context.SaveChanges();
                return user;
            }
        }
    }
}
