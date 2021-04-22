using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    public interface ISwimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }
    public interface IFlyable
    {
        int MaxHeight
        {
            get
            {
                return 0;
            }
        }
        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }
    public interface IRunnable
    {
        int MaxSpeed
        {
            get
            {
                return 0;
            }
        }
        void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
    }
    public interface IAnimal
    {
        int LifeDuration
        {
            get
            {
                return 0;
            }
        }
        void Voice()
        {
            Console.WriteLine("No voice!");
        }
        void ShowInfo()
        {
            Console.WriteLine($"I am a MyProgram.SolutionTest+MyAnimal and I live approximately 20 years.");
        }
    }

    class Cat : IAnimal, IRunnable
    {
        public int MaxSpeed { get; set; }
        public int LifeDuration { get; set; }
        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
        public void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"I am a {typeof(Cat)} and I live approximately {LifeDuration} years.");
        }
    }
    class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; set; }
        public int MaxHeight { get; set; }
        public void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"I am a {typeof(Eagle)} and I live approximately {LifeDuration} years.");
        }
    }
    class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"I am a {typeof(Shark)} and I live approximately {LifeDuration} years.");
        }
    }
}
