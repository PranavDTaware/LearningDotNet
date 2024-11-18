using CRM;

namespace Membership
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


        public static bool Register(string loginId, string name, string password,
                                    string email, string contactnumber, string location)
        {
            bool status = false;

            Customer theCustomer = new Customer();
            theCustomer.FullName = name;
            theCustomer.UserId = loginId;
            theCustomer.Password = password;
            theCustomer.Email = email;
            theCustomer.Location = location;

            if(theCustomer != null)
                status = true;
            return status;

        }

        public static bool ChangePassword(string loginId, string existingPassword, string newPassword )
        {
            bool status = false;
            // Set new password for userId
            // you need make changes into file, database...


            return status;
        }

        public static bool ForgotPassword(string loginId)
        {
            bool status = false;
            //logic in future
            return status;
        }
    }
}
