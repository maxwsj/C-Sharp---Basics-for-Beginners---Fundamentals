using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpFundamentals

{
    class Program

    {
        /// <summary>
        /// Write a program that reads a text file and displays
        /// the number of words.
        /// </summary>
        static void Main()

        {
            var path = @"C:\Users\maxnt\Desktop.txt";
            var input = File.ReadAllText(path);

            var inputWithoutLineBreaks = input.Replace("\r\n", " ")
                .Replace("\n", " ")
                .Replace("\r", " ");


            var words = inputWithoutLineBreaks.Split(' ');
            var wordsSanitizedList = new List<string>();

            foreach (var word in words)

            {
                if (!string.IsNullOrWhiteSpace(word))

                {
                    wordsSanitizedList.Add(word);
                }
            }
            Console.WriteLine("Number of words:  " + wordsSanitizedList.Count);
        }

    }

}