using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace FirstSpring
{
    class MyProgram
    {
        static object locker = new object();
        public static void Counter(int count)
        {

            Thread factorial = new Thread(new ParameterizedThreadStart(factorial_WhileLoop));

            factorial.Start(count);
            
            Thread fibonacci = new Thread(new ParameterizedThreadStart(Fibonachi));
            fibonacci.Start(count);
        }
        public static void factorial_WhileLoop(object x)
        {
            lock (locker)
            {
                int number = (int)x;
                int result = 1;
                while (number != 1)
                {
                    result = result * number;
                    number = number - 1;
                }
                Console.WriteLine($"Factorial is: {result }");
            }
        }
        public static void Fibonachi(object x)
        {

            int num = (int)x;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine($"Fibbonaci number is: {a + b}");
        }

    }
}
