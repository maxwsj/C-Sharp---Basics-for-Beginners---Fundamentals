using System;

namespace ReferenceTypesNValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}, b:{1}", a, b));

            // Reference Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]));

        }
    }
}
