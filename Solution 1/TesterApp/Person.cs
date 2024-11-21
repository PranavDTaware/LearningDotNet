using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace HR
{
    //user defined structure Type
    public struct Point
    {
        public int X;
        public int Y; 
    }
    public class Person
    {
        public Person() 
        {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;
        }
        public Person(string fname, string lname, DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = bdate;
        }
        protected string FirstName {  get; set; } 
        protected string LastName { get; set; }
        protected DateTime BirthDate {get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate;
        }

        public static implicit operator Person(Employee v)
        {
            throw new NotImplementedException();
        }
    }
}
