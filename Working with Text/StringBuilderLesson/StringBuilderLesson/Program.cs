using System;
using System.Text;

namespace StringBuilderLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can also specify a starting string
            var otherBuilder = new StringBuilder("Hello World");
            Console.WriteLine(otherBuilder);
            var builder = new StringBuilder();
            builder.Append('-', 10); // makes the '-' apear 10 times
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            // REPLACE
            builder.Replace('-', '+');

            // REMOVE
            builder.Remove(0, 10); // Specify an index

            // INSERT
            builder.Insert(0, new string('-', 10)); // we need to specify an index ({0} to put something at the beggining of the string, the second argument we can pass anaything
            

            Console.WriteLine(builder);

            // We can use a indexer to access individual characters in the string builder
            Console.WriteLine(builder[0]);

            // We can chain string builders
            otherBuilder.AppendLine().Append('-', 10);
        }
    }
}
