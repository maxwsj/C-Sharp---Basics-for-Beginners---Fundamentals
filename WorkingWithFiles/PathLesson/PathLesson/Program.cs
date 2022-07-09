using System;
using System.IO;

namespace PathLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provides a number of methods that makes it really easy to work with a string that represents
            var path = @"C:\Users\maxnt\Documents\GitHub\C-Sharp---Basics-for-Beginners---Fundamentals.sln";

            // What we would do to get .sln from this path without the Path methods
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // With path method
            Path.GetExtension(path);

            // Or we can use get filename to only extract the file name in that path.
            Path.GetFileName(path);

            // Filename without extension
            Path.GetFileNameWithoutExtension(path);

            // Get the directory name
            Path.GetDirectoryName(path);


        }
    }
}
