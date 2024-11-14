using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class ConstreadonlyTest
    {
        enum Weekdays { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        enum Months { Jan, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec};


        class MathEngine
        {
            public const int count = 10; // at the time of declaration you have to initialize
            public readonly double PI; // you can declare but no need to initialize here
            
            public MathEngine(int num1, int num2)
            {
                PI = 3.14;
            }
            public MathEngine()
            { 
                PI = 3.14; // initialized only once
            }

            public int Add(int op1, int op2)
            {

                return op1 + op2;
            }
        }


        static void Main(string[] args)
        {

            Weekdays day = Weekdays.Wed;
            Console.WriteLine("{0}", day);

        }
    }
}
