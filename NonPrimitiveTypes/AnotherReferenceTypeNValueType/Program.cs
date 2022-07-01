using System;

namespace AnotherReferenceTypeNValueType
{   public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The value here is used and then immediatly destroyed
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            // The value here is stored in the heap
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
