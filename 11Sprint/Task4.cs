using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using System.Reflection;
namespace FirstSpring
{
    class ReflectorAssembly
    {
        
        public class LargeBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }
            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }
        public class Box
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }
            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }
        public class SmallBox
        {
            public static void UnPackingBox(string size)
            {
                Console.WriteLine($"I am unpacking {size} box.");
            }
            public static void InBox(string size)
            {
                Console.WriteLine($"I am in {size} box.");
            }
        }
        public interface ILookingForBox
        {
            public static void LookForBox(string str)
            {

            }
        }
        public interface IPackingBox
        {
            public static void PackBox(string str)
            {

            }
        }
        public static void WriteAssemblies()
        {
            //Console.WriteLine("Class: {0}", Assembly.GetExecutingAssembly().FullName);
            Console.WriteLine("Class: {0}", typeof(ReflectorAssembly).Name);
            Console.WriteLine($"Method: {MethodBase.GetCurrentMethod().Name}");
            foreach (var type in typeof(ReflectorAssembly).GetNestedTypes())
            {
                if(!type.IsInterface) Console.WriteLine("Class: {0}",  type.Name);
                else Console.WriteLine($"Interface: {type.Name}");
                foreach(var method in type.GetMethods(BindingFlags.Public | BindingFlags.Static))
                {
                    
                    Console.WriteLine($"Method: {method.Name}");
                    if (!type.IsInterface)
                    {
                        string size;
                        if (type.Name == "LargeBox") size = "large";
                        else if (type.Name == "Box") size = "middle";
                        else size = "small";
                        method.Invoke(null, new object[] {size});
                    }
                }                
            }
            
            
        }
    }
}
