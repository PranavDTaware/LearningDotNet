using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
     class SalesEmployee : Employee
    {
        public float Incentive;
        public SalesEmployee(string fname, string lname, 
                            DateTime bdate,int id, string dept,
                            float bsalary, int workingDays, float incentive)
                            :base(fname, lname, bdate, id, dept, bsalary, workingDays)
        {
            this.Incentive = incentive;
        }

        public override float CalculateSalary()
        {
            return base.CalculateSalary() + Incentive;
        }

        public override string ToString()
        {
            return base.ToString()+ " " + Incentive;
        }
    }
}
