using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.getInstance();
            Singleton singleton2 = Singleton.getInstance();
            Singleton singleton3 = Singleton.getInstance();

            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());
            Console.WriteLine(singleton3.GetHashCode());
        }
    }
}
