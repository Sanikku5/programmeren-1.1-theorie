using System;

namespace highest_lowest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, highest, lowest;

            Console.Write("Enter number one: ");
            numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter number two: ");
            numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                highest = numberOne;
                lowest = numberTwo;
            }
            else
            {
                highest = numberTwo;
                lowest = numberOne;
            }
            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Lowest: {lowest}");
        }
    }
}
