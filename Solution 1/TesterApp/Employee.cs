﻿

namespace HR
{
    public class Employee : Person
    {
        public Employee() :base()
        {
        }

        public Employee(string fname, string lname, DateTime bdate,
                        int id, string dept, float bsalary, int workingDays)
                        : base(fname, lname, bdate)
        {
            ID = id;
            Department = dept;
            BasicSalary = bsalary;
            WorkingDays = workingDays;
        }

        public int ID { get; set; }
        public string Department { get; set; }
        public float BasicSalary { get; set; }
        public int WorkingDays { get; set; }

        public float CalculateSalary()
        {
            float salary = BasicSalary + (100 *WorkingDays);
            return salary;
        }

    }
}