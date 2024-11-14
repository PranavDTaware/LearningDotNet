using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class BoxingUnboxingTest
    {
        public static void Main(string[] args)
        {
            //Value Type

            int count = 45;


            // reference type
            // Boxing is technique where valu type are transformed into reference type
            // value type is wrapped in reference type

            object o = count;
            Console.WriteLine(o);

            //Unboxing is a technique where reference type is unwrapped and value type is recieved
           
            int result = (int) o;
            Console.WriteLine(result);
        }
    }
}
