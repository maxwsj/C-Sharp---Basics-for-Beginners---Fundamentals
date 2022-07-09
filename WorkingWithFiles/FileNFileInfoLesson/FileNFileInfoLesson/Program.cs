using System;
using System.IO;

namespace FileNFileInfoLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true); // true indicates if the files exists we can overrite it
            File.Delete(path);

            // Checking if a file exists
            if (File.Exists(path))
            {
                //
            }

            // If we want to read all the text in a file we can use
            var content = File.ReadAllText(path); // returns a string

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            


        }
    }
}
