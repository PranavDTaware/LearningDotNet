using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private float balance; //variable

        public float Balance // property
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(float amount)  //constructor
        {
            balance = amount;
        }

        public void Deposit(float amount) //method
        {
           balance += amount;
        }

        public void Withdraw(float amount) //method
        {
            balance -= amount;
        }

        //is always overrided to convert object state into string
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
