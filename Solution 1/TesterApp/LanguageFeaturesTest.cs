

namespace TesterApp
{
    public class LanguageFeaturesTest
    {
        interface IPrintable
        {
            void Print();
        }
        public static void Main (string[] args)
        {
            //in c# called as value types in

            //primitve types in C, C++
            int result = 10;
            float price = 65.4F;
            bool status = false;
            double score = 46484;



            //reference type

            LanguageFeaturesTest test = new LanguageFeaturesTest();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
