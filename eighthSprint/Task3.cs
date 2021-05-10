using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace FirstSpring
{
    class MyTasks
    {
        public static void Tasks()
        {
            int[] sequence_array = new int[10];

            Task[] tasks1 = new Task[3]
            {
                new Task(() =>
                {
                    for(int i = 0; i < 10; i++)
                    {
                        sequence_array[i] = i * i;
                    }
                    Console.WriteLine("Calculated!");
                }),
                new Task(() =>
                {
                    for(int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Bye!");
                }),
                new Task(() =>{
                    for(int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(sequence_array[i]);
                    }
                    Console.WriteLine("Bye!");
                }
                )
            };
            foreach (var item in tasks1)
            {
                item.Start();
                item.Wait();
            }
            Console.WriteLine("Main done!");
        }
    }
}
