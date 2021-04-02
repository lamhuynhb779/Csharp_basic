using System;

namespace MyApplication
{
    class Program
    {
        /// <summary>
        /// This is main function that program will run
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "Lam Huynh";
            int charPos = myString.IndexOf("H");
            Console.WriteLine(myString.Substring(charPos));

        }
    }
}
