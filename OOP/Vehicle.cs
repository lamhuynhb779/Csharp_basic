using System;

namespace OOP
{
    // If you don't want other classes to inherit from a class, use the "sealed" keyword:
    // sealed class Vehicle
    public class Vehicle
    {
        public string branch = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}