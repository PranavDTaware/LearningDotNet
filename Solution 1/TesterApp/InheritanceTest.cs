

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
            Console.ReadLine();
        }
    }
}
