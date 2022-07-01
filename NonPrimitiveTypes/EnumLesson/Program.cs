using System;

namespace EnumLesson
{
    // Because Enum is a new type, we need to define it at the namespace level.
    public enum ShippingMethod
    {
        // If we don't set any values to the members of this enum, the first member is going to be automatically set to zero. From there, every member value is gonna be incremented by 1.
        // For good practice, always explicitly set values for these enums.
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;

            // Casting this integer in a numeric value of this enum
            Console.WriteLine((int)method);

            // There are times when we receive numbers from an other system ( could be a database or it could be a third party application supplying some data). And we need to convert that number, that integer to a shipping method in our application.
            // We  can use casting to convert an integer to a shipping method
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // Converting an Enum into String (or a String into an Enum)
            Console.WriteLine(method.ToString()); // By default console.WriteLine always calls the ToString method on any value we pass to it.

            // Converting an String into Enum
            var methodName = "Express"; // We need to convert this method name into a shipping enumerationg

            // The first parameter is a type object, the second, the value that we want to convert
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        }

    }
}
