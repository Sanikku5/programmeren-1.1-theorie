namespace DayOfWeek_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public DayOfWeek DayOfWeek(int dayNumber) {
            switch (dayNumber)
            {
                case 1:
                    return DayOfWeek.Monday;
                default:
                    return 0;
            }
        }
    }
}
