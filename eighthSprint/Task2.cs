using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;
namespace FirstSpring
{
    class MainThreadProgram
    {
        public static void Sum()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1) Console.WriteLine($"Enter the {i}st number: ");
                else if (i == 2) Console.WriteLine($"Enter the {i}nd number: ");
                else if (i == 3) Console.WriteLine($"Enter the {i}rd number: ");
                else Console.WriteLine($"Enter the {i}th number: ");
                sum += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum is: {sum}");
        }
        public static void Product()
        {
            List<int> list = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }
            var result = list.Aggregate((x, y) => x * y);
            Thread.Sleep(10000);
            Console.WriteLine($"Product is: {result}");
        }
        public static (Thread, Thread) Calculator()
        {
            Thread sumThread = new Thread(new ThreadStart(Product));
            Thread productThread = new Thread(new ThreadStart(Sum));
            sumThread.Start();
            productThread.Start();
            return (productThread, sumThread);
        }
    }
}
