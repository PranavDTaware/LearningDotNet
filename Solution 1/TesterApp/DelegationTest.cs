

namespace TesterApp
{
    // define delegate
    public delegate void Handler();
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
            Handler operation1 = null;
            operation1 = new Handler(PayIncomeTax);
         

            Handler operation2 = null;
            operation2 = new Handler(PayProfessionalTax);
            

            Handler operation3 = null;
            operation3 = new Handler(PayServiceTax); // unicast delegate


            Handler masterOperationManager = null;

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
