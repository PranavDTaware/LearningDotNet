using Banking;

namespace TesterApp
{
    // define delegate

    //delegate is a wrapper for function pointers
    class DelegationTest
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine("15% income is deducted from your account");
        }

        public static void PayServiceTax()
        {
            Console.WriteLine("25% service is deducted from your account");
        }

        public static void PayProfessionalTax()
        {
            Console.WriteLine("10% Professional is deducted from your account");
        }

        static void Main(string[] args)
        {  //early Binding
           //PayIncomeTax();

            //late Binding
            AccountHandler operation1 = null;
            operation1 = new AccountHandler(PayIncomeTax); //registering name of fuction to be invoked


            AccountHandler operation2 = null;
            operation2 = new AccountHandler(PayProfessionalTax);


            AccountHandler operation3 = null;
            operation3 = new AccountHandler(PayServiceTax); // unicast delegate


            AccountHandler masterOperationManager = null;

            masterOperationManager += operation1;  // multicast 
            masterOperationManager += operation2;
            masterOperationManager += operation3;
            masterOperationManager(); //only one invocation  // multicast deligate

            Console.WriteLine("after unregistration");
            masterOperationManager -= operation3;
            masterOperationManager();

            Console.ReadLine();
        }
    }
}
