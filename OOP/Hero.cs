using System;

namespace OOP
{
    abstract class Hero
    {
        public abstract void sayHi();
        public void attack()
        {
            Console.WriteLine("The hero attacks");
        }
        
    }
}