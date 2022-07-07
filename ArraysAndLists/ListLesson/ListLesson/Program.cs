using System.Collections.Generic;

namespace ListLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            // We can add values to our list
            numbers.Add(1);
            // Whenever we see an IEnumerable we can use aan array or a list there.
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                System.Console.WriteLine(number);

            System.Console.WriteLine();
            System.Console.WriteLine($"index of 1: {numbers.IndexOf(1)}");

            System.Console.WriteLine();
            System.Console.WriteLine($"last index of 1: {numbers.LastIndexOf(1)}");

            System.Console.WriteLine();
            System.Console.WriteLine($"Count: {numbers.Count}");

            System.Console.WriteLine();
            System.Console.WriteLine("Remove");
            // numbers.Remove(1);
            /*foreach (var number in numbers)
                System.Console.WriteLine(number);*/

            // What is we wanted to remove all the ones ?
            // We can do it with the for loop

            // In C# we are not allowed to modify our collection inside a foreach loop
            /*foreach (var number in numbers)
            {
                if (number == 1)
                    numbers.Remove(number);
            }*/

            // We need to use the for loop
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                System.Console.WriteLine(number);

            numbers.Clear(); // Remove all elements from the list
            System.Console.WriteLine($"Count: {numbers.Count}");

        }
    }
}
