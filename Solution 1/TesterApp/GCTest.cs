using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class GCTest
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5000; i++)
            {
                Person thePerson = new Person("Pranav", "Taware", new DateTime(2001, 10, 20));
                Console.WriteLine(thePerson);
            }
            Console.ReadLine();
        }
    }
}
