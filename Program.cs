using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine("Integer Array:");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Console.WriteLine();

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine("Boolean Array:");
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            Console.WriteLine();

            var names = new string[3] { "Mary", "John", "Jim" };
            Console.WriteLine("String Array:");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }
    }
}
