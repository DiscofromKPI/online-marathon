using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
namespace FirstSpring
{

    class ReflectFullClass
    {
        public static void WriteAllInClass(Type type)
        {
            Console.WriteLine($"Hello, {type.Name}!");
            var fields = type.GetFields();
            Console.WriteLine($"There are {fields.Length} fields in {type.Name}: ");
            foreach (var field in fields)
            {
                Console.Write(field.Name + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {type.GetProperties().Length} properties in {type.Name}: ");
            foreach (var prop in type.GetProperties())
            {
                Console.Write(prop.Name + ", ");
            }
            Console.WriteLine();
            var methods = type.GetMethods()
                .Where(m => !m.Name.Contains("get_") && !m.Name.Contains("set_") && !typeof(object)
                .GetMethods()
                .Select(t => t.Name)
                .Contains(m.Name));
            Console.WriteLine($"There are {methods.Count()} methods in {type.Name}:");
            foreach (var method in methods)
            {
                Console.Write(method.Name + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {type.GetNestedTypes().Length} interfaces in {type.Name}: ");
            foreach (var inter in type.GetNestedTypes())
            {
                Console.Write(inter.Name + ", ");
            }
        }
    }


}
