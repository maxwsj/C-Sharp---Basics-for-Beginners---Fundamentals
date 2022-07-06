using System;

namespace RandomClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            /*for (var i = 0; i < 10; i++)
            {
                // Console.WriteLine(random.Next());
                // If we want to create rnadom numbers between 1 and 10 we simply supply them
                // Console.WriteLine(random.Next(1, 10));

                // Generating random chaaracters (Obs: 'a' represents 97) (0 and 26 represents the quantity of characters of the US)
                //Console.Write((char)('a' + random.Next(0, 26)));
            }*/

            // Improving the code above
            // clean code for our password length
            const int passwordLength = 10;

            // Initializing our random characteres array
            var buffer = new char[passwordLength];

            // Filling our random character array
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            // creating a string from our random charaters arrays
            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
