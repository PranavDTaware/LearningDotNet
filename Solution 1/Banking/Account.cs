namespace Banking
{
    // define delegeate
    public delegate void AccountHandler();
    public class Account
    {
        
        //can class have state, behaviour
        private float balance; //variable // state
        public event AccountHandler underbalance;  //event 
        public event AccountHandler overbalance;  //event

        public float Balance // property
        {
            get { return balance; }
            set { balance = value; }
        }

        //behaviour

        public Account(float amount)  //constructor
        {
            balance = amount;
        }


        //condition
        public void Monitor()  //Observing Balance
        {
            //check balance against threshold
            if (balance < 5000)
            {
                //raise an event underbalance
                //trigger
                underbalance();  //invoking event
            }
            else if (balance >= 250000)
            {
                // raise an event overbalance
                //trigger
                overbalance();  //invoking event
            }
        }

        public void Deposit(float amount) //method
        {
            balance += amount;
            Monitor();
        }

        public void Withdraw(float amount) //method
        {
            balance -= amount;
            Monitor();
        }

        //dynamic behaviour
        //underbalance, overbalance as events


        //is always overrided to convert object state into string
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
