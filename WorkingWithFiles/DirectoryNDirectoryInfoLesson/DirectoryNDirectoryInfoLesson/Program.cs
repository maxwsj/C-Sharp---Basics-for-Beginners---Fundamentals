using System;
using System.IO;

namespace DirectoryNDirectoryInfoLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"C:\Users\maxnt\Documents\GitHub\C-Sharp---Basics-for-Beginners---Fundamentals", "*.*", SearchOption.AllDirectories);

            /*foreach (var file in files)
            {
                Console.WriteLine(file);
            }*/

            var directories = Directory.GetDirectories(@"C:\Users\maxnt\Documents\GitHub\C-Sharp---Basics-for-Beginners---Fundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            // Check if a directory exists or not
            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
