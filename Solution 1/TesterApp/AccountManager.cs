using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    public static class AccountManager
    {

        public static bool Login(string username, string password)
        {
            bool status = false;
            if (username == "pranav" && password == "123")
            {
                status = true;
            }
            return status;
        }


        public static bool Register(string loginId, string namestring password, string email, int contactnumber, string location)
        {
            bool status = false;
            Customer customer1 = new Customer();
        }
    }
}
