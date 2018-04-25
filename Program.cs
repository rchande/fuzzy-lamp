using System;

namespace c73
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = (1, 2);
            var y = (2, 3);
            Console.WriteLine(x == y);
        }
    }
}
