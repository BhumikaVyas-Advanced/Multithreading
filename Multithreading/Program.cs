using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //creating thread 1 and 2 to run simulatenously

            Thread t1 = new Thread(MakeCheeseBread);
            Thread t2 = new Thread(MakeCoffee);

            t1.Start();   //start making cheese-bread
            t2.Start();   //start making coffee
        }

        public static void MakeCheeseBread()
        {

            Console.WriteLine("Take bread");
            Console.WriteLine("Take Cheese");
            Console.WriteLine("Spread Cheese");
            Console.WriteLine("Heat in oven");
            Thread.Sleep(5000);
            Console.WriteLine("Cheese-Bread made!");


        }
        public static void MakeCoffee()
        {
            Console.WriteLine("Take a cup");
            Console.WriteLine("Add instant coffee");
            Console.WriteLine("Add milk");
            Thread.Sleep(5000);
            Console.WriteLine("Mix coffee well");
            Thread.Sleep(6000);
            Console.WriteLine("Coffee ready!");

        }
    }
}
