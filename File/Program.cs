using System.IO;
using System;

namespace File
{
    enum Options
    {
        y,
        n
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your file name: ");
            string fileName = Console.ReadLine();
            string extension = ".txt";
            string path = "./file/";
            string filePath = path + fileName + extension;

            if (!isExistingFile(filePath)) {
                Console.WriteLine("Enter your content: ");
                string content = Console.ReadLine();
                System.IO.File.WriteAllText(filePath, content + Environment.NewLine);
            } else {
                Console.WriteLine($"File {filePath} is existing!!!");
            }
            
            string option;
            do
            {
                Console.WriteLine("Do you want to append more content (y/n)?");
                option = Console.ReadLine();

                if (isYes(option)) {
                    Console.WriteLine("Please enter your content: ");
                    string appendContent = Console.ReadLine();
                    System.IO.File.AppendAllText(filePath, appendContent + Environment.NewLine);
                }

            } while (isYes(option));

            Console.WriteLine(System.IO.File.ReadAllText(filePath));
        }

        static bool isYes(string option)
        {
            return option == Options.y.ToString();
        }

        static bool isExistingFile(string filePath)
        {
            return System.IO.File.Exists(filePath);
        }

    }
}
