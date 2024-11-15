using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class ConstreadonlyTest
    {
        private static float radius;

        enum Weekdays { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        enum Months { Jan, Feb, Mar, Apr, May, June, July, Aug, Sep, Oct, Nov, Dec};
        enum FavouriteColor { Red, Green, Blue, Black };
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

        class ConstReadonlyTest
        {
            static float area;
            static float circum;

             public static void ViewNames(params string[] names)
            {
                foreach( string name in names)
                {
                    Console.WriteLine(name);
                }
            }


            public static void Swap(ref int n1, ref int n2)
            {
                int temp = n1; 
                n1 = n2; 
                n2 = temp;
            }

            public static void Calculate(float radius, out float area, out float circum)
            {
                area = 3.14f * radius * radius;
                circum = 2 * 3.14f * radius;
            }
        }

        static void Main(string[] args)
        {
            #region Enum Examples

            Weekdays day = Weekdays.Fri;
            Months month = Months.Nov;
            FavouriteColor myColor = FavouriteColor.Red;
            Console.WriteLine("{0},{1}", day, month);
            #endregion

            #region Collection Examples
            int[] schoolMarks;

            int[] marks = new int[9];

            int[] enggMarks = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] dacMarks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            string[] names = new string[] { "Pranav", "Rohan", "Sagar", "Gauri" };

            List<string> students = new List<string>();
            students.Add("Rajesh");
            students.Add("Ganesh");
            students.Add("Ramesh");


            List<Person> people = new List<Person>();
            people.Add(new Person("Pranav", "Taware", new DateTime(2001, 10, 20)));
            people.Add(new Person("Aditya", "More", new DateTime(2001, 10, 20)));
            people.Add(new Person("Ganesh", "More", new DateTime(2001, 10, 20)));

            foreach (Person prn in people)
            {
                Console.WriteLine(prn);
            }


            #endregion
            

            #region MultipleVersionsofViewNames
            ConstReadonlyTest.ViewNames("Rahul Sir", "Bakul Madam", "Shrinivas Sir");
            ConstReadonlyTest.ViewNames("Jeevan", "Sangita");
            #endregion

            int MumbaiPopulation = 45000;
            int PunePopulation = 3400;
            ConstReadonlyTest.Swap(ref MumbaiPopulation, ref PunePopulation);

            float area;
            float circum;

            float radius = 4;

            ConstReadonlyTest.Calculate(radius, out area, out circum);

            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Circum = {0}", circum); 


            Console.ReadLine();

        }
    }
}
