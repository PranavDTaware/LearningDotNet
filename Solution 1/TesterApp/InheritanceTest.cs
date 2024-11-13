

using HR;

namespace TesterApp
{
    public class InheritanceTest
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(2001, 10, 20);
            Person thePerson = new Person("Pranav","Taware", birthdate);
            Console.WriteLine(thePerson);

            DateTime birthdate2 = new DateTime(2003, 9, 8);
            Employee emp = new Employee("Aditya", "More", birthdate2,101, "Sales", 30000, 24);
            float salary = emp.CalculateSalary();
            Console.WriteLine("Aditya's Salary = {0} ", salary);


            DateTime birthdate3 = new DateTime(2001, 3, 4);
            Employee emp2 = new SalesEmployee("Hemant", "More", birthdate3, 111, "Projects", 40000, 27, 5000);
            float salary2 = emp2.CalculateSalary();
            Console.WriteLine("Hemant's Salary = {0} ", salary2);



            //Person prn = thePerson; //instance of person

            //Person prn = emp;
            Person prn = emp2;
            //Polymorphism for ToString will be worked...
            Console.WriteLine("Polymorphism Behaviour");
            Console.WriteLine(prn);

            Console.ReadLine();
        }
    }
}
