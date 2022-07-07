using System;

namespace ArraysLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine($"{numbers.Length}");

            // IndexOf() -> We use this method to find the position of an element
            var index = Array.IndexOf(numbers, 9); // Returns an integer
            Console.WriteLine($"The index of 9: {index}");

            // Clear() -> Set some indexes of our array to zero
            // If it was an array of booleans, they would  be set to false
            // Other types of elements (strings) would be set to null
            // Has tree parameters: 1- is the array, 2-is the starting index of the range of elements to clear, 3- the number of elements that we would like to clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach(var n in numbers)
                Console.WriteLine(n);

            // Copy()
            // Takes tree parameters: Source array, destination, number of elements we would like to copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Console.WriteLine("Effect of Sort()");
            Array.Sort(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse() -> Sort reverselly
            Console.WriteLine("Effect of Reverse()");
            Array.Reverse(numbers);
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
