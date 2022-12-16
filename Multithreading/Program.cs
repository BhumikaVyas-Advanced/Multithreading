using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creating thread 1 and 2 to run simulatenously

            Thread t1 = new Thread(ThreadFunc1);
            Thread t2 = new Thread(ThreadFunc2);

            t1.Start();
            t2.Start();
        }

        public static void ThreadFunc1()
        {
           
            /*for (int i =0; i< 100; i++)
            {
                Console.WriteLine("Thread 1 : {0}", i);
                if(i == 5)
                {
                    Thread.Sleep(15000);
                }
            }*/

        }
        public static void ThreadFunc2()
        {
            
            /*for (int i =0; i< 10; i++)
            {
                Console.WriteLine("Thread 2 : {0}", i);
               
            }*/

        }
    }
}
