namespace profit_exercise_1
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
            double[] profits = new double[Enum.GetValues(typeof(MonthsOfYear)).Length]; //of gewoon 12
            double sumOfProfits = 0;
            
            for (int i = 0; i < profits.Length; i++)
            {
                MonthsOfYear currentMonth = (MonthsOfYear)i+1;
                Console.Write($"Enter the profit for month {currentMonth}: ");
                double currentProfit = double.Parse(Console.ReadLine());
                profits[i] = currentProfit;
                sumOfProfits += currentProfit;
            }

            double averageProfit = sumOfProfits / profits.Length;

            Console.WriteLine($"The average profit is: {averageProfit:0.00}\n");

            for (int i = 0; i < profits.Length; i++)
            {
                if (profits[i] > averageProfit)
                {
                    Console.WriteLine($"The profit of {(MonthsOfYear)i+1} is higher than average ({profits[i]})");
                }
            }
        }
    }
}
