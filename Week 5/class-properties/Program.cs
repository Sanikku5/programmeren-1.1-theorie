namespace class_properties
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
            Employee wiley = new("Wiley", "Finch", "Informatica", 5200);
            wiley.DisplayInfo();

            //Console.WriteLine(wiley.FullName);

            //wiley.IncreaseSalary(150000);
            //wiley.DisplayInfo();

            //wiley.ChangeLastName("Goldenchain");
            //wiley.DisplayInfo();

            //wiley.ChangeDepartment("Bahamas");
            //wiley.DisplayInfo();

            //Console.WriteLine(wiley.FullName);

            wiley.IncreaseSalary(1500); // Komt goed met backing field
            wiley.DisplayInfo();

            wiley.IncreaseSalary(-1500); // Komt niet goed met backing field
            wiley.DisplayInfo();
        }
    }
}
