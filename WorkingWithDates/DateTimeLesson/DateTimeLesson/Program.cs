using System;

namespace DateTimeLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dateTime = new DateTime(2015, 1, 1);

            // Getting the current datetime
            var now = DateTime.Now;

            /*// Getting today's date irrespective of the time
            var today = DateTime.Today;

            Console.WriteLine($"Today: {today}");
            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");

            // Dates and Hours in C# are immutable

            // So, how to modify them  ?
            var tomorrow =  now.AddDays(1); // Returns tomorrow current time

            // Going back in the past dd/mm/yy ?
            var yesterday = now.AddDays(-1); // Returns yesterday current time*/

            Console.WriteLine(now.ToLongDateString()); // quarta-feira, 6 de julho de 2022
            Console.WriteLine(now.ToShortDateString()); // 06/07/2022
            Console.WriteLine(now.ToLongTimeString()); // 23:58:37
            Console.WriteLine(now.ToShortDateString()); // 06/07/2022

            // What if we wanted to show buff date and time ?
            Console.WriteLine(now.ToString()); // 07/07/2022 00:01:53
            Console.WriteLine(now.ToString("yyy-MM-dd HH:mm")); // we can pass the date format that we want inside the parentesis
        }
    }
}
