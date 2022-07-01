using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Long declaration
            int[] longDeclaration = new int[3];

            // Short declaration
            var numbers = new int[3];

            // Setting elements on the array
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // ---- Boolean declaration -----
            var flags = new bool[3];

            // Setting elements on the array
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            // Object Initialization Syntax
            var names = new string[3] { "Max", "Andressa", "Zoe" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
}
