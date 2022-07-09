using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////// EXERCISE 1 ///////////////
            /*Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                // Consecutive Number
                // Ex: 5-6-7-8-9
                //  numbers[i] = 6
                // numbers[i - 1] = 5 + 1 = 6

                // next iteration
                //  numbers[i] = 7
                // numbers[i - 1] = 6 + 1 = 7

                *//*******************************//*
                // Non Consecutive Number
                // Ex: 5-8-7-2-9
                //  numbers[i] = 8
                // numbers[i - 1] = 5 + 1 = 6
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);*/


            /////////// EXERCISE 2 ///////////////
            /*Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            // Checks immediatly if it is empty
            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            // Add to the numbers list the input's values dinamically
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            // List that will receive the unique values
            var uniques = new List<int>();

            // We need to create a bool value that will be used to display our text
            var includesDuplicates = false;

            // We loop over our numbers list to check if it contaians duplicates values
            foreach (var number in numbers)
            {
                // if the number that we are adding doesn't already exists in our uniques list, we add it in our uniques list, if not we break and change the includesDuplicates bool to true
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            // If the includesDuplicates is true, we display the string Duplicate
            if (includesDuplicates)
                Console.WriteLine("Duplicate");*/


            /////////// EXERCISE 3 ///////////////
            /*Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            // Returns an array
            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                // Converts the first element of our array into hours
                var hour = Convert.ToInt32(components[0]);
                // Converts the second element of our array into minutes
                var minute = Convert.ToInt32(components[1]);

                // Validates the hour
                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }*/



            /////////// EXERCISE 4 ///////////////
            /*Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);*/

            /////////// EXERCISE 5 ///////////////
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }

    }
}
