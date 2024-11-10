using System.Collections.Generic;
using System.Reflection;
using Banking;
using Maths;

Console.WriteLine("Hello, World!");


var p = new{firstname = "Pranav" , lastname = "Taware"};
Console.WriteLine(p.firstname + " " + p.lastname);


int count = 10;
count++;

string company = "Transflower";


Console.WriteLine("Count = " +count);
Console.WriteLine(company);


// Account
Account acc1 = new Account(50000);
acc1.Deposit(10000);
Console.WriteLine("amount deposited = "  + acc1.GetBalance());

acc1.Withdraw(5000);
Console.WriteLine("Amount after withdrawal = " + acc1.GetBalance());

float currentbalance1 = acc1.GetBalance();  // Get the current balance and store it in a variable
Console.WriteLine("Final Balance = " + currentbalance1);


Account acc2 = new Account();
Console.WriteLine(acc2.GetBalance());

List<Account> accounts = new List<Account>();
accounts.Add(acc1);
accounts.Add(acc2);

foreach(Account theAccount in accounts)
    {
        float result = theAccount.GetBalance();
        Console.WriteLine("Current Balance = {0}", result);
    }


// Complex
Complex c1 = new Complex(60,50);
Complex c2 = new Complex(20,40);

Complex add = c1+c2;

Console.WriteLine(add.Real);
Console.WriteLine(add.Imag);