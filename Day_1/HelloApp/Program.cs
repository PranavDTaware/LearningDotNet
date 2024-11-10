using System.Collections.Generic;
using System.Reflection;
using Banking;
using Maths;

Console.WriteLine("Hello, World!");

Account acc1 = new Account(50000);
acc1.Deposit(10000);

float currentbanlce1 = acc1.GetBalance();
Console.WriteLine(currentbanlce1);

acc1.Withdraw(5000);
Console.WriteLine(acc1.GetBalance());


Complex c1 = new Complex(60,56);
Complex c2 = new Complex(20,40);


Complex add = c1+c2;

Console.WriteLine(add.Real);