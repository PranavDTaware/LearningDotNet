

using Membership;

namespace TesterApp
{
    class SecurityTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login Demo");
            Console.WriteLine("Enter User Id : ");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter your Password : ");
            string password = Console.ReadLine();

            bool status = AccountManager.Login(userId, password);
            if (status)
            {
                Console.WriteLine("Welcome...");
            }
            else
            {
                Console.WriteLine("Invalid User....");
            }

            Console.ReadLine();
        }
    }
}
