using System;


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
