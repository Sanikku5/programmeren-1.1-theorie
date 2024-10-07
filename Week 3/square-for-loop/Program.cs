namespace square_for_loop
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
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i}^2 is {i * i}");
            }
            Console.WriteLine("End of program");
        }
    }
}
