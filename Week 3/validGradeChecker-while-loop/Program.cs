namespace validGradeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            bool validGrade = false;
            while (!validGrade)
            {
                Console.Write("Enter a grade (1-10): ");
                int grade = int.Parse(Console.ReadLine());

                // Assignment of validGrade through an if-block

                //if (grade >= 1 && grade <= 10)
                //{
                //    validGrade = true;
                //}
                //else
                //{
                //    Console.WriteLine("Enter a valid grade between 1 and 10!");
                //}

                // Direct assignment of validGrade with boolean logic

                validGrade = grade >= 1 && grade <= 10;
            }
            Console.WriteLine("End of program");
        }
    }
}
