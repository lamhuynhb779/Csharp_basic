using System;

namespace OOP
{
    /// <summary>
    ///  Remove "public" keyword before "class" because class Hero don't have "public" before "abstract"
    /// </summary>
    class Saitama : Hero
    {
        public override void sayHi()
        {
            Console.WriteLine("Saitama says hello!");
        }
    }
}