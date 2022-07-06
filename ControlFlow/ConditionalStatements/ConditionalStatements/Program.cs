using System;

namespace ConditionalStatements
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // ------- If / Else Statement -------
            /*
            int hour = 10;

            if (hour > 0 && hour < 12)
            { 
                Console.WriteLine("It's morning."); 
            }
            else if (hour >= 12 && hour < 18)
            { 
                Console.WriteLine("It's afternoon."); 
            }
            else
            { 
                Console.WriteLine("It's evening."); 
            }
            */

            // ------- Conditional Operator -------
            // bool isGoldCustomer = true;

            /* Without conditional Operator
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            */

            // With conditional operator

            /* float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price); */

            // ------- Switch Case -------
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autum a nd beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;

            }

            // Executing the same code with two or more cases.
            switch (season)
            {
                // If we wanted the two cases to execute the same thing, we can do this:
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;

            }
        }
    }
}
