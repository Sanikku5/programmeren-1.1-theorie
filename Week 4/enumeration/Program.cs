namespace enumeration
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
            Console.Write("Enter a monthnumber (1..12): ");
            int monthNumber = int.Parse(Console.ReadLine());

            MonthsOfYear month = (MonthsOfYear)monthNumber;
            Season currentSeason = GetSeasonByMonth(month);

            Console.WriteLine($"You entered month {month} and belongs to season {currentSeason}");
        }

        public Season GetSeasonByMonth(MonthsOfYear month)
        {
            switch (month)
            {
                case MonthsOfYear.December:
                case MonthsOfYear.January:
                case MonthsOfYear.February:
                    return Season.Winter;
                case MonthsOfYear.March:
                case MonthsOfYear.April:
                case MonthsOfYear.May:
                    return Season.Spring;
                case MonthsOfYear.June:
                case MonthsOfYear.July:
                case MonthsOfYear.August:
                    return Season.Summer;
                case MonthsOfYear.September:
                case MonthsOfYear.October:
                case MonthsOfYear.November:
                    return Season.Autumn;
                default:
                    throw new Exception("not a valid month");
            }
        }
    }
}
