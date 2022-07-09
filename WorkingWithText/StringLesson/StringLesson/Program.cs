using System;

namespace StringLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Max William ";
            ////////// TRIM METHOD //////////////
            Console.WriteLine($"Trim: '{fullName.Trim()}'");
            ////////// TRIM METHOD WITH CHAIAN //////////////
            Console.WriteLine($"Trim: '{fullName.Trim().ToUpper()}'");

            // WHAT IF WE WANTED TO BREAAK THIS STRING INTO FIRST NAME AN LAST NAME ? //
            // One way is looking for the index of the space and based on that, split the string in two parts

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index); // how many characters do we want ? up to the index of the white space
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"Spliting the name: {firstName} {lastName}");

            ////////// SPLIT //////////////
            var names = fullName.Split(' ');
            Console.WriteLine($"Split: First Name: {names[0]}");
            Console.WriteLine($"Split: Last Name: {names[1]}");

            ////////// REPLACE //////////////
            var replacedName = fullName.Replace("Max", "MaxWiliam");
            Console.WriteLine(replacedName);

            var replacedChar = fullName.Replace("a", "A");
            Console.WriteLine(replacedChar);

            ////////// REPLACE //////////////
            // We can check if a input or field is filled

            // White spaces strings passed here because it was the first method that microsoft provided to us, to get through this, we would need to trim() the string first
            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");

            // In later version MS provided a new method
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            ////////// CONVERTING STRINGS INTO NUMBERS //////////////
            var str = "19";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            ////////// CONVERTING NUMBERS INTO STRINGS //////////////
            float price = 29.95f;
            // Formating with currency
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

        }
    }
}
