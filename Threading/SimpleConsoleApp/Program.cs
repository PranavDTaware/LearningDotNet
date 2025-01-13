using System;
using System.Threading;


namespace SimpleConsoleApp
{
    //Multithreaded Threaded Application

    class Program
    {
        // At operation system level:
        // Kernel object are used for execution
        // need to execute  both functions is independent manner
        // Process 
        // Thread
        // Mutex, semaphore, Event, Crritical Section
        // Side effects of Multithreading

        // System.Threading 
        static void StoreData()
        {
            Thread theTread=Thread.CurrentThread;
            Console.WriteLine("StoreData fn Thread =" + theTread.ManagedThreadId);
            Console.WriteLine("Storing data into JSON file "); 
            Thread.Sleep(3000);  
            Console.WriteLine("Data is successfully writte in file JSON "); 
        }
        static void GetRemoteData()
        {
            Thread theTread=Thread.CurrentThread;
            Console.WriteLine("GetRemoteData fn Thread =" + theTread.ManagedThreadId);
  
            Console.WriteLine("Getting users data from git repository");
            Thread.Sleep(4000);
            //access data from external applications using  RPC
             Console.WriteLine("Data is received from Remote Server");
        }
        static void Main(string[] args)
        {
            // Primary Thread
            Thread theTread=Thread.CurrentThread;
            Console.WriteLine("Main function invoker =" + theTread.ManagedThreadId);
            Thread.Sleep(5000);
            Display();
            //Creating two secondary Threaded using .NET sdk
            ThreadStart thDelegate1=new ThreadStart(StoreData);
            Thread thread2=new Thread(thDelegate1);
            ThreadStart thDelegate2=new ThreadStart(GetRemoteData);
            Thread thread3=new Thread(thDelegate2);
            thread2.Start();
            thread3.Start();
            Console.WriteLine("Main function is about to be terminated......");
        }
        public static void Display()
        {
                 Thread theTread=Thread.CurrentThread;
                 Console.WriteLine("Display fn Thread =" + theTread.ManagedThreadId);
                 Console.WriteLine("Displaying product catalog data");
        }
    }
}
