using HR;

namespace TesterApp
{
    class GCTest
    {
        static void Main(string[] args)
        {
            Person thePerson = null;
            for (int i = 0; i < 5000; i++)
            {
                //Person thePerson = new Person("Pranav", "Taware", new DateTime(2001, 10, 20));
                //Console.WriteLine(thePerson);
                thePerson.show();
            }
            Console.ReadLine();
        }
    }
}
