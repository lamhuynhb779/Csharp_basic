using System;

namespace Enum
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            Level level = Level.High;
            Console.WriteLine(level);

            Months monthName = Months.April;
            int month = (int)Months.April;
            Console.WriteLine(monthName);
            Console.WriteLine(month);
        }
    }
}
