using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace FirstSpring
{
    public class ReflectProperties
    {
        public class TestProperties
        {
            public string FirstName { get; set; }
            internal string LastName { get; set; }
            protected int Age { get; set; }
            string PhoneNumber { get; set; }

        }
        public static void WriteProperties()
        {
            foreach (var property in typeof(TestProperties).GetRuntimeProperties())
            {
                Console.WriteLine($"Property name: {property.Name}");
                Console.WriteLine($"Property type: {property.PropertyType}");
                Console.WriteLine($"Read-Write:    {property.CanRead}");
                Console.WriteLine($"Accessibility: {GetAccessibility(property)}");
                Console.WriteLine();
            }
        }
        public static string GetAccessibility(PropertyInfo property)
        {
            if (property.SetMethod.IsPublic)
                return "Public";
            else if (property.SetMethod.IsPrivate)
                return "Private";
            else if (property.SetMethod.IsFamily)
                return "Protected";
            else if (property.SetMethod.IsAssembly)
                return "Internal";
            else
                return "Protected Internal/Friend";

        }
    }

}
