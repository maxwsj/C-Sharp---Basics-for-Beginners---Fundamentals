using System;
using System.Collections.Generic;

namespace ArraysNListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--------- Exercise 1 -------------*/
            /*var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name or type ENTER to quit: ");

                var input = Console.ReadLine();

                // String.IsNullOrWhiteSpace checks if a variable is null or empty (for strings)
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                // It is - 2 because two others already shown in the console
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
            else if (names.Count == 2)
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            else if (names.Count == 1)
                Console.WriteLine($"{names[0]} likes your post.");
            else
                Console.WriteLine();*/

            /*--------- Exercise 2 -------------*/
            /*Console.Write("What's your name? ");
            var name = Console.ReadLine();

            // Create an arraay of the type char with the length of the name
            var array = new char[name.Length];

            // Loop over our name, the loop quantaty is based on the naame's length  and it'll be decremented
            for (var i = name.Length; i > 0; i--)
                // We access our array of char with the name length minus index, and add access the name  index (with the counter index) minus one, so that we can get the reversed  letter
                array[name.Length - i] = name[i - 1]; // we replace the char position with the reversed char value

            // Create an new string with our array
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);*/

            /*--------- Exercise 3 -------------*/
            /*var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine($"You`ve previously entered {number}");
                    // Continue will make the loop start again
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);*/

            /*--------- Exercise 4 -------------*/
            /* var numbers = new List<int>();

             while (true)
             {
                 Console.Write("Write a number or Quit to exit: ");
                 var input = Console.ReadLine();

                 if (input.ToLower() == "quit")
                     break;
                 numbers.Add(Convert.ToInt32(input));
             }

             var uniques = new List<int>();
             foreach (var number in numbers)
             {
                 // If it do not contains the number from numbers it will be added to the uniques list
                 // Contains() returns a boolean
                 if (!uniques.Contains(number))
                     uniques.Add(number);
             }

             Console.WriteLine("Unique numbers:");
             foreach (var number in uniques)
                 Console.WriteLine(number);*/

            /*--------- Exercise 5 -------------*/

            // Declare an empty string array
            string[] elements;

            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            // Creating a new list of integers
            var numbers = new List<int>();

            // taking our elements list and converting and adding it's items to the numbers list
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            // Creating our smallests list 
            var smallests = new List<int>();

            // Looping with while, with the condition os minus 3
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];

                // Looping over our numbers to add to our smallests list the smallest number
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);

        }
    }
}
