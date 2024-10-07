namespace starBlockDisplay_nested_for_loop
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
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (!IsEven(j))
                        Console.Write("X");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            }
        }

        bool IsEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
