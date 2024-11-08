using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{

    // Abstraction
    public class Person
    {   
        // Encapsulation
        private string firstname;
        private string lastname;
        private int age;

        // Constructor Overloading
        public Person()
        {
            this.firstname = "Pranav";
            this.lastname = "Taware";
            this.age = 23;
        }

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public void Show()
        {
            Console.WriteLine(this.firstname + " " + this.lastname + " " + this.age);
        }
    }
}
