using System;

namespace TimeSpanLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /***************** CREATING *****************/
            ///////////// First way to create a time span ///////////
            var timeSpan = new TimeSpan(1, 2, 3); // The arguments that we are passing here are: hours, minutes and seconds

            ////////// Second way to create a time span ///////////
            // What if we didn't have aa value for minutes and seconds ?
            var timeSpan1 = new TimeSpan(1, 0, 0);

            // A more readble way to create the same time span object, is to use static methods on the time span structure
            var timeSpanStatic = TimeSpan.FromHours(1);

            ///////////// Third way to create a time span ///////////
            ///// If we have two Daytime objects and we subtract them, the result is a timespan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            /***************** PROPERTIES *****************/
            Console.WriteLine($"Minutes: {timeSpan.Minutes}"); // Returns the minutes component of your time span object
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}"); // Converts that timespan object into minutes

            /***************** ADD *****************/
            Console.WriteLine($"Add Example: {timeSpan.Add(TimeSpan.FromMinutes(8))}"); // We added 8 minutes
            Console.WriteLine($"Subtract Example: {timeSpan.Subtract(TimeSpan.FromMinutes(8))}"); // We subtracted 8 minutes

            /***************** CONVERTING TO STRING *****************/
            // ToString
            Console.WriteLine($"ToString: {timeSpan.ToString()}")

            // Parse
            Console.WriteLine($"ToString: {TimeSpan.Parse("01:02:03")}");

        }
    }
}
