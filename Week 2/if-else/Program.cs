using System;

namespace if_else
{
    internal class Program
    {
        const int PassingGrade = 55;
        static void Main(string[] args)
        {
            Console.Write("Enter a grade: ");
            int grade = int.Parse(Console.ReadLine());

            // Als-dan selectie
            if (grade < PassingGrade)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You failed the exam.");
                Console.WriteLine("Better luck next time.");
            }
            else if (grade > 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are amazing!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You passed the exam");
            }
            Console.ResetColor();
            Console.WriteLine("The exam was on the 11th of September.");
        }
    }
}
