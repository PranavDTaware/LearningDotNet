

Console.WriteLine("Hello, World!");
int count = 20;
count = count++;
if (count <= 300)
{
    while (count < 299)
    {
        Console.WriteLine("count = {0}", count);
        count++;
    }
}

Console.WriteLine("Enter your name:");
    String name = Console.ReadLine();
Console.WriteLine("Welcome to Code" + name); //traditional syntax
Console.WriteLine("Welcome to Code {0}", name); //{} place holder



//Static functions
static int Addition(int num1, int num2)
{ 
    return num1 + num2; 
}

static int Multiplication(int num1, int num2)
{
    return num1 * num2;
}

int result = Addition(65, 56);
int result2 = Multiplication(20, 40);