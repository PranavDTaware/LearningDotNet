using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Employee: Person
    {
        private int id;
        private double da;
        private double hra;
        private double daysworking;

        public Employee(string firstname, string lastname, int age, int id, double da, double hra, double daysworking) : base(firstname, lastname, age)
        {
            this.id = id;
            this.da = da;
            this.hra = hra;
            this.daysworking = daysworking;
        }

        public new void Show()
        {
            base.Show();

            Console.WriteLine(this.id + " " + this.da + " " + this.hra + " " + this.daysworking + " ");
        }
    }
}
