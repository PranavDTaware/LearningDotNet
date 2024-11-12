using Banking;

namespace TesterApp
{
    class BankTest
    {

        static void Main(string[] args)
        {
            Account acc = new Account(50000);

            Console.WriteLine("1.withdraw");
            Console.WriteLine("2.deposit");
            int option = int .Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Amount : ");
            float amount = float.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        acc.Withdraw(amount);
                    }
                    break;
                case 2:
                    {
                        acc.Deposit(amount);
                    }
                    break;
            }

            float balance = acc.Balance;
            Console.WriteLine("Your remaining Balance = {0}", balance);
            Console.WriteLine(acc);
            Console.ReadLine();
        }
    }
}
