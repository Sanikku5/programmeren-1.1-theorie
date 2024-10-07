using System;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            int year = ReadYearFromConsole();
            bool isLeapYear = IsLeapYear(year);
            DisplayResult(isLeapYear, year);
        }

        int ReadYearFromConsole()
        {
            Console.Write("Enter a year: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }

        bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void DisplayResult(bool isLeapYear, int year)
        {
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
