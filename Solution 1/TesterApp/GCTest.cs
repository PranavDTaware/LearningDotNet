using HR;

namespace TesterApp
{
    class GCTest
    {
        static void Main(string[] args)
        {
            //Deterministic Finalization
            //InDeterministic Finalization

            Person thePerson = new Person("Pranav", "Taware", new DateTime(2001, 10, 20)); ;
            for (int i = 0; i < 5000; i++)
            {
                //Person thePerson = new Person("Pranav", "Taware", new DateTime(2001, 10, 20));
                //Console.WriteLine(thePerson);
                thePerson.show();
            }

            //GC.SuppressFinalize(thePerson);
            //GC.WaitForPendingFinalizers();
            GC.Collect();

            Console.ReadLine();
        }
    }
}
