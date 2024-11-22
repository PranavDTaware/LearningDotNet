using Banking;



namespace TesterApp
{
    //Subscriber 1
    public static class Government
    {
        // will always contain handlers
        public static void PayIncomeTax()
        {
            Console.WriteLine("15% income tax is getting deducted from your account");
        }
        public static void SetIncomeTaxEnquiry()
        {
            Console.WriteLine("Income tax officials have been informed about payee as well as register arrest warrant");
        }
    }

    //Subscriber 2
    public static class HDFCBank
    {
        public static void BlockAccount()
        {
            Console.WriteLine("Your account has been blocked due to insufficient funds ");
        }

        public static void SendEmail()
        {
            Console.WriteLine("Banking operations deatils are sent to your registered email id");
        }
    }



    class EventDemoTest
    {
        static void Main(string[] args)
        {
            //Observer pattern


            //Event Driven Mechanism apply

            //define delegate accountHandler
            //define your class with events based on delegates
            //write a logic  to raise events based on conditions
            //Define event handler logic for events
            //Register event handlers with events before method invokation
            //invoke basic operation against instance (Account)

            // Programs behaviour is decided based on events defined,
            //                                                  event handler logic implemented
            //                                                  condition set for event triggering logic
            Account acct = new Account(45000);

            //events are getting registere  with event handlers

            //subcribe to account 
            acct.underbalance += new AccountHandler(HDFCBank.BlockAccount);  //register
            acct.underbalance += new AccountHandler(HDFCBank.SendEmail);
            
            acct.overbalance += new AccountHandler(Government.PayIncomeTax);   //register
            acct.overbalance += new AccountHandler(Government.SetIncomeTaxEnquiry);


            Console.WriteLine("Initial Balance = {0}", acct.Balance);
            Console.WriteLine("Enter Amount to withdraw");
            float amount = float.Parse(Console.ReadLine());

            acct.Deposit(amount);
            Console.WriteLine("Net Balance after operation : ");
            Console.WriteLine(acct.Balance);


            Console.ReadLine();
        }
    }
}
