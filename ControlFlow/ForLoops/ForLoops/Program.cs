using System;

namespace LoopsExamples
{
    class Program
    {

        static void Main(string[] args)
        {
            // ------- For Loop -----------
            /* for (var i = 1; i <= 10; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }

             for (var i = 10; i >= 1; i--)
             {
                 if (i % 2 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/
            //----------  END -------------

            // ------- For Each -----------
            // If we would use the for loop
            /*var name = "Max William";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }*/

            // With for each
            // Whenever we have an enumerable object like a string or array or anay kind of list, it's much eaasier to iterate over them using a for each.
            /*var name = "Max William";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }*/

            // Iterate over an arraya
            /*var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/
            //----------  END -------------

            // ------- While Loops -----------
            /*var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }*/

            /*while (true)
            {
                Console.Write("type your name: ");
                var input = Console.ReadLine();

                // Checks if a string is empty (this method expects a string an returns a boolean value
                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("@Echo: "  + input);
            }*/

            // Using the continue

            while (true)
            {
                Console.Write("type your name: ");
                var input = Console.ReadLine();

                // Checks if a string is empty (this method expects a string an returns a boolean value
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    // will continue to beggining of the loop
                    continue;
                }

                break;

            }
        }
    }
}
