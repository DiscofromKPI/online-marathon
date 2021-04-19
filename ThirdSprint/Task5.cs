using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    public delegate void EventHandler();
    class EventProgram
    {
        public event EventHandler Show;
        public EventProgram()
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;
            Show();
        }
        public static void Dog()
        {
            Console.WriteLine("Dog");

        }
        public static void Cat()
        {
            Console.WriteLine("Cat");
        }
        public static void Mouse()
        {
            Console.WriteLine("Mouse");
        }
        public static void Elephant()
        {
            Console.WriteLine("Elephant");
        }
    }
}
