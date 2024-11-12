using System;
using TesterApp;


//access specifiers in c#
//public: variable can be used outside the program class
//private: variable can be used only by member functions
//protected: variable can be accesd accross inheritance(derived class and base classes)
//internal: (Assembly Scope)


class Program
{
    private string programName;


    // Methods
    public void SetProgram(string name) //Setter in C++
    {
        this.programName = name;
    }
    public string GetProgram() //Getter in C++
    {
        return this.programName;
    }



    //Property: This concept is took from Visual Basic
    //Use this(Modern way to write getter setter)
    public string Name
    {
        get { return this.programName; }
        set { programName = value; }
    }
   


    public Program()  // default constructor
    {
        this.programName = "FirstProgram";
    }

    public Program(string name) // parameterised constructor
    {
        this.programName = name;
    }

    //Entry Point
    static void Main(string[] args)
    {
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

        //static functions
        int result = Addition(65, 56);
        int result2 = Multiplication(20, 40);

        // Display Results
        Console.WriteLine("Addition result: " + result);
        Console.WriteLine("Multiplication result: " + result2);



        //(Object) Instance method call
        Program theProgram = new Program();
        theProgram.Name = "My Program"; //Set block is called

        Console.WriteLine("Program title=" + theProgram.Name); // Get bloack is called
        theProgram.Display();

        Product theProduct1 = new Product(1, "Rose", "Valentine", 4500, 10);
        Product theProduct2 = new Product(2, "Lily", "Wedding FLower", 5000, 10);
        Product theProduct3 = new Product(3, "Gerbera", "Wedding FLower", 3000, 10);

        Console.WriteLine(theProduct1);
        Console.WriteLine(theProduct2);
        Console.WriteLine(theProduct3);


        Account acc1 = new Account(60000);
        acc1.Deposit(5000);
        Console.WriteLine("amount deposited = " + acc1.Balance);
        
        Console.ReadLine(); // to hold the program
    }


    //Static functions
    static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }



    //Member function(non-static function)

    
    public void Display()
    {
        Console.WriteLine("Processing logic for Display");
        Console.WriteLine("Program instance....");
    }
}
