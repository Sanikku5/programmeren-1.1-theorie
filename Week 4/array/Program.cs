namespace array
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
            int[] row = { 10, 20, 30, 40 };

            // Hoe kopiëer je een array: 
            int[] copy = new int[row.Length];

            for (int i = 0; i < row.Length; i++)
            {
                copy[i] = row[i];
            }

            row[0]++;

            Console.WriteLine(copy[0]);
        }
    }
}