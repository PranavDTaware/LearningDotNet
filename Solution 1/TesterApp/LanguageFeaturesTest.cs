

namespace TesterApp
{
    public class LanguageFeaturesTest
    {
        //Prototype
        // is used to define contract
        // is used to define specification
        // is used to define guidlines

        // Printing is a skill, a capaility

        interface IPrintable
        {
            void Print();
            void start();
            void stop();
        }

        interface IScannable
        {
            void scan();
        }


        //Prototyp ein implemented by concrete class
        class Printer : IPrintable, IScannable  //Multiple interface Inheritance 
        {
            public void scan()
            {
                Console.WriteLine("Scanning Document");
            }

            public void start()
            {
                Console.WriteLine("Printer has started");
            }

            public void stop()
            {
                Console.WriteLine("Printer has stopped");
            }

            void IPrintable.Print()
            {
                Console.WriteLine("Printing Data");
            }
        }

        class ThreeDPrinter : IPrintable, IScannable
        {
            public void scan()
            {
                Console.WriteLine("Started scanning 3D model");
            }
            public void start()
            {
                Console.WriteLine("3D Printer has started building model...");
            }

            public void stop()
            {
                Console.WriteLine("3D Printer has stopped building model....");
            }

            void IPrintable.Print()
            {
                Console.WriteLine("Building 3-D Model...");
            }
        }
        public static void Main (string[] args)
        {
            //in c# called as value types in
            //values of value type are stored on  stact memory
            //primitve types in C, C++
            int result = 10;
            float price = 65.4F;
            bool status = false;
            double score = 46484;



            //reference type
            //class, interface, delegate, event
            //values pointed by reference type are always store on heap

            // Heap is managd by Garbage Collecetor

            IPrintable outputDevice = null;

            Printer laserprinter = new Printer();
            outputDevice = laserprinter;

            // late binding
            outputDevice.Print();  //Printer method will be called
            outputDevice.start();
            outputDevice.stop();


            ThreeDPrinter jobPrinter = new ThreeDPrinter();
            outputDevice = jobPrinter;
            
            //late binding
            outputDevice.Print(); //3D printer method will be called
            outputDevice.start();
            outputDevice.stop();

            LanguageFeaturesTest test = new LanguageFeaturesTest();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
