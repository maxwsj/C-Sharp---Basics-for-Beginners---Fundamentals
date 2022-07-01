using Classes.Math;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of type person
            var max = new Person();
            max.FirstName = "Max";
            max.LastName = "William";
            max.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);

            System.Console.WriteLine(result);
            
        }
    }

}
