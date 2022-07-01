using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Max";
            var lastName = "William";

            var fullName = $"{firstName} {lastName}";

            var myFullName = string.Format("My  name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Max", "Andressa", "Zoe" };
            var formattedNames = string.Join(", ", names);

            // Without Verbatim Strings
            var text = "Hi Max \nLook into the following paths: \nc:\\folder1\\folder2 \nc:folder3\\folder4";


            // With Verbatim Strings
            var verbatimTxt = @"Hi Max
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(verbatimTxt);

        }
    }
}
