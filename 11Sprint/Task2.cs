using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;

using System.Reflection;

namespace FirstSpring
{

    public class ReflectMethod
    {
        public static class Methods
        {
            public static void Hello(string hello)
            {
                Console.WriteLine($"Hello:parameter={hello}");
            }
            public static void Welcome(string welcome)
            {
                Console.WriteLine($"Welcome:parameter={welcome}");
            }
            public static void Bye(string bye)
            {
                Console.WriteLine($"Bye:parameter={bye}");
            }

        }
        public static void InvokeMethod(string[] arr)
        {

            foreach (var method in typeof(Methods).GetMethods(BindingFlags.Public | BindingFlags.Static))
            {
                foreach (var m in arr)
                {
                    method.Invoke(null, new object[] { m });
                }
            }
        }
    }



}
