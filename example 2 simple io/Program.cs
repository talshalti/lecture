using System;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            string userAge = GetUserData();
            Console.WriteLine();

            // John says...
            Console.WriteLine("{0}, Number {0}, Number {0}", userAge);

            // Prints: 20, 10, 30
            //Console.WriteLine("{1}, {0}, {2}", 10, 20, 30);

            FormatNumericalData(userAge);

            Console.ReadLine();
        }

        #region Get some information about the user
        static string GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console.
            Console.WriteLine("Hello {0}!  You are {1} years old.",
              userName, userAge);

            // Restore previous color.
            Console.ForegroundColor = prevColor;

            return userAge;
        }
        #endregion

        #region Format some numerical data
        // Now make use of some format tags.
        static void FormatNumericalData(string userAge)
        {
            int UserAge = 100;
            int.TryParse(userAge, out UserAge);
            Console.WriteLine("The value {0} in various formats:", UserAge);
            Console.WriteLine("c format: {0:c}", UserAge);
            Console.WriteLine("d9 format: {0:d9}", UserAge);
            Console.WriteLine("f3 format: {0:f3}", UserAge);
            Console.WriteLine("n format: {0:n}", UserAge);

            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine($"E format: {UserAge:E}");
            Console.WriteLine($"e format: {UserAge:e}");
            Console.WriteLine($"X format: {UserAge:X}");
            Console.WriteLine($"x format: {UserAge:x}");
        }
        #endregion
    }
}
