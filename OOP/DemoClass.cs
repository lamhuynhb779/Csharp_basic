using System;

namespace OOP
{
    public class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }

        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}