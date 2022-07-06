using System;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            /*----- Count how many numbers between 1 and 100 are divisible by 3 ------*/
            /*var divisibleByTree = 0;
            for (var i = 0; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    divisibleByTree++;
                }
            }
            Console.WriteLine(divisibleByTree);*/

            // EXERCISE 2
            /*var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                // Let the user input already in to lowercase and check if it is "ok"
                if (input.ToLower() == "ok")
                    break;

                // Converts string to input
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);*/

            // EXERCISE 3
            /*--------Factorial number--------*/
            /*Console.Write("Write a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine($"{number}! = {factorial}");*/

            // EXERCISE 4
            /*-------- Guess the number --------*/
            // We create the random number and already add the number limit
            /*var number = new Random().Next(1, 10);

            Console.WriteLine("Secret is " + number);
            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }*/

            // EXERCISE 5
            /*-------- Highest number --------*/

            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var highest = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > highest)
                    highest = number;
            }

            Console.WriteLine($"Max is {highest}");

        }
    }
}
