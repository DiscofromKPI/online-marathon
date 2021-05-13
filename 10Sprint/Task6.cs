class Cat : IMoving, IEating, IBasking
    {
        public void Eat()
        {
            Console.WriteLine("Oh! My milk!");
        }
        public void Bask()
        {
            Console.WriteLine("Mrrr-Mrrr-Mrrr...");
        }
        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
    class Bird : IMoving, IEating, IFlyable
    {
        public void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }
        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
    }
    class Parrot : Bird, IMoving, IKryaking, IEating, IBasking, IFlyable
    {
        public void Bask()
        {
            Console.WriteLine("Chuh-Chuh-Chuh...");
        }
        public void Move()
        {
            Console.WriteLine("I can jump!");
        }
        public void Eat()
        {
            Console.WriteLine("Oh! My seeds and fruits!");
        }

        public void Krya()
        {
            Console.WriteLine("Krya-Krya-Krya...");
        }
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }
    }
    class Duck : Bird, IFlyable, IKryaking, IMoving, IEating
    {
        public void Move()
        {
            Console.WriteLine("I can swimm!");
        }
        public void Krya()
        {
            Console.WriteLine("Krya-Krya!");
        }
        public void Fly()
        {
            Console.WriteLine("I believe, I can fly");
        }
        public void Eat()
        {
            Console.WriteLine("Oh! My corn!");
        }
    }
    public interface IMoving
    {
        public void Move();

    }
    interface IEating
    {
        void Eat();
    }
    public interface IFlyable
    {
        public void Fly();

    }
    interface IBasking
    {
        void Bask();
    }
    interface IKryaking
    {
        void Krya();
    }
