using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FirstSpring
{
    class Task4
    {
        public static string GetWord(string input, string seed)
        {
            string[] arr = input.Split(" ");
            string longest = arr.OrderByDescending(x => x.Length).First();
            return string.Join("", ((longest.Length > seed.Length) ? longest : seed).SkipWhile(x => x != 'a'));

        }
    }
}
