using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.numberOfWheel = 4;
            car.honk();
            Console.WriteLine(car.color);
            Console.WriteLine(car.numberOfWheel); 

            /**
            Why Encapsulation?

    Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
    Flexible: the programmer can change one part of the code without affecting other parts
    Increased security of data

            */

            Person person = new Person();
            person.Name = "Lam";
            Console.WriteLine(person.Name);
            person.Birthday = "20/01/2020";
            Console.WriteLine(person.Birthday);


            // Polymorphism and Overriding Methods
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.animalSound();
            pig.animalSound();
            dog.animalSound();

            // Abstract Classes and Methods
            Saitama saitama = new Saitama();
            saitama.sayHi();
            saitama.attack();

            // Interface
            Banana banana = new Banana();
            banana.makeIn();

            // Multiple Interfaces 
            DemoClass demoClass = new DemoClass();
            demoClass.myMethod();
            demoClass.myOtherMethod();

        }
    }
}
