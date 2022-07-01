using System;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        // Declaring a method (void doesn't return any values)
        public void Introduce()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

}
