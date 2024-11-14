

using System.Drawing;

namespace TesterApp
{
    public class LanguageFeaturesTest
    {

        // Abstract class enforce overriding
        public abstract class Shape
        {
            //Minimum one method has to be abstract method
           abstract public void Draw();
            public string Color {  get; set; }
            public string Width { get; set; }
            public void Display()
            {
                Console.WriteLine("Shape is getting Displayed....");
            }

        }

        public class Line : Shape
        {
            public Point StartPoint;
            public Point EndPoint;
            public override void Draw()
            {
                Console.WriteLine("Line is Drawn..");
                Console.WriteLine("Frirst Point {0},{1}",StartPoint.X, StartPoint.Y);
                Console.WriteLine("Second Point {0},{1}", EndPoint.X, EndPoint.Y);
                Console.WriteLine("Color = {0}", Color);
                Console.WriteLine("Width = {0}", Width);
            }
        }




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
            //class : are of two types: cont=concrete class and abstract
            //interface, delegate, event
            //values pointed by reference type are always store on heap

            // Heap is managd by Garbage Collecetor


            Console.WriteLine("Demo for Interface interface");
            IPrintable outputDevice = null;

            Printer laserprinter = new Printer();
            outputDevice = laserprinter;

            // late binding
            outputDevice.start();
            outputDevice.Print();  //Printer method will be called
            outputDevice.stop();


            outputDevice = new ThreeDPrinter();
            
            //late binding
            outputDevice.start();
            outputDevice.Print(); //3D printer method will be called
            outputDevice.stop();

            LanguageFeaturesTest test = new LanguageFeaturesTest();


            Console.WriteLine("Demo abstract class");
            Shape theShape = new Line();
            theShape.Color = "Red";
            theShape.Width = "5";
            Line l = theShape as Line;
            l.StartPoint = new Point();
            l.StartPoint.X = 96;
            l.StartPoint.Y = 5;
            l.EndPoint = new Point();
            l.EndPoint.X = 45;
            l.EndPoint.Y = 5;
            theShape.Draw();


            Console.WriteLine("Welcome to C#");
            Console.ReadLine();


            //early binding : resolving funtion at compile time
            //late binding : resolve fuction at runtime
        }
    }
}
