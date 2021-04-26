using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FirstSpring
{
    class Task2
    {
        public static void Position(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 5) Console.WriteLine(i + 1);
            }
        }
        public static void Remove(List<int> numbers)
        {
            numbers = numbers.Where(x => x <= 20).ToList();
            foreach (int elem in numbers) Console.WriteLine(elem);
        }
        public static void Insert(List<int> numbers)
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            foreach (int elem in numbers) Console.WriteLine(elem);
        }
        public static void Sort(List<int> numbers)
        {
            numbers.Sort();
            foreach (int elem in numbers) Console.WriteLine(elem);
        }
    }
}
