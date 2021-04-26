using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (var item in lookup)
            {
                foreach (var value in item)
                {
                    Console.WriteLine(value.Name + " " + value.Price);
                }
                Console.WriteLine(item.Key + " " + item.Sum(x => x.Price));

            }
        }
        
    }
}
