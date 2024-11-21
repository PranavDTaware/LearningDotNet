



using ConsoleApp1;
using Mathlib;

Console.WriteLine("Hello, World!");


Calculator math = new Calculator();

int addResult = math.Add(18, 20);
int subResult = math.Subtract(20, 2);

Console.WriteLine("Result = {0}", addResult);

Console.WriteLine("Result = {0}", subResult);



//Class Library
int num1 = 34;
int num2 = 56;

int realResult = MathEngine.Addition(num1, num2);
Console.WriteLine("Result = {0}", realResult);



Complex c1 = new Complex(54, 44);
Complex c2 = new Complex(35, 65);
Complex c3 = c1 + c2;


Console.WriteLine("Complex Result = {0}", c3.Imag);

Console.ReadLine();