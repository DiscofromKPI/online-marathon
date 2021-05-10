using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading;
namespace FirstSpring
{
    class Buyer : PersonInTheShop
    {
        static Semaphore sem = new Semaphore(10, 10);
        Thread thread;
        public Buyer(string name)
        {
            thread = new Thread(new ThreadStart(CreateThread)) { Name = name };
            thread.Start();
        }
        public void CreateThread()
        {
            sem.WaitOne();
            Enter();
            SelectGroceries();
            Pay();
            Leave();
            sem.Release();
        }
    }
    class PersonInTheShop
    {
        public static void Enter() {
            Console.WriteLine("I am entering");
        }
        public static void SelectGroceries() { Console.WriteLine("I am selecting"); }
        public static void Pay() { Console.WriteLine("I am paying"); }

        public static void Leave() { Console.WriteLine("I am Leaving"); }
    }
}
