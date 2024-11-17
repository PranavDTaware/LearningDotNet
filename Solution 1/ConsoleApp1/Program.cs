// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");




Calculator math = new Calculator();

int addResult = math.Add(18, 20);
int subResult = math.Subtract(20, 2);

Console.WriteLine("Result = {0}", addResult);

Console.WriteLine("Result = {0}", subResult);