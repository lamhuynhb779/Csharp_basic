using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myNumbers = {5, 1, 8, 9};
            Console.WriteLine(myNumbers.Max());
            Console.WriteLine(myNumbers.Min());
            Console.WriteLine(myNumbers.Sum());

            // Declare an array
            string[] cars;

            // Add values, using new
            cars = new string[] {"Volvo", "BMW", "Ford"};

            string[] cars1 = new string[4];
            string[] cars2 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars3 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars4 = {"Volvo", "BMW", "Ford", "Mazda"};

        }
    }
}
