using System;

namespace CSExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            /*
            Console.WriteLine("---- Number Validation ----");
            Console.WriteLine("Please Write a number:");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (userNumber >= 1 && userNumber <= 10)
            {
                Console.WriteLine("Valid");
            } 
            else if (userNumber > 10)
            {
                Console.WriteLine("Invalid");
            }
            */

            // Exercise 2
            /*
            Console.WriteLine("---- The highest number ----");
            Console.Write("Write the first number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the second number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());
            
            int highestValue = (number1 > number2) ? number1 : number2;
            Console.WriteLine($"The highest value is: {highestValue}");
            */

            // Exercise 3
            /*
            Console.WriteLine("---- Landscape or portrait----");
            Console.Write("Please, enter the width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the height of the image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
            */

            // Exercise 4
            Console.WriteLine("---- Speed Limit ----");
            Console.Write("Please, enter a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the car's speed: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            } else
            {
                const int kmDemeritPoint = 5;
                var demeritPoint = (carSpeed - speedLimit) / kmDemeritPoint;

                if(demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                } else
                {
                    Console.WriteLine($"Demerit Points: {demeritPoint}");
                }

            }


        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
