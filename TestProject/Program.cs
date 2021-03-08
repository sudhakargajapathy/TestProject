using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            char alphabet = 'A';
            string firstName = "Sudhakar";
            var lastName = "Gajapathy";
            float price = 10.25f;

            Console.WriteLine("Hello World!  ~From Sudhakar");
            Console.WriteLine(number);
            Console.WriteLine(alphabet);
            Console.WriteLine(firstName);
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine(price);
        }
    }
}
