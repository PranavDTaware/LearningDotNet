

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

            // test for Registeration

            Console.WriteLine("Customer Registeration");
            Console.WriteLine("Full Name : ");
            string fullname = Console.ReadLine();

            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your Contactnumber : ");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter your Location : ");
            string location = Console.ReadLine();


            status =  AccountManager.Register(userId, password, fullname, email, contactNumber, location);
            if (status)
            {
                Console.WriteLine("Test Passed...");
            }
            else
            {
                Console.WriteLine("Test Failed...");
            }
            Console.ReadLine();
        }
    }
}
