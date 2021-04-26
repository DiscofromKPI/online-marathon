using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Task3
    {
        public static void SearchKeys(Dictionary<string, string> persons)
        {
            foreach (var key in persons) Console.WriteLine(key.Key);
        }
        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (var key in persons) Console.WriteLine(key.Value);
        }
        public static void SearchAdmin(Dictionary<string, string> persons)
        {
            foreach (var key in persons)
            {
                if (key.Value == "Admin") Console.WriteLine(key.Key + " " + key.Value);
            }
        }
    }
}
