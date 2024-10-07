namespace validGradeChecker_do_while_loop
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
            bool validGrade;
            do
            {
                Console.Write("Enter a grade (1..10): ");
                int grade = int.Parse(Console.ReadLine());
                validGrade = grade >= 1 && grade <= 10;
            } while (!validGrade);
            Console.WriteLine("End of program");
        }
    }
}
