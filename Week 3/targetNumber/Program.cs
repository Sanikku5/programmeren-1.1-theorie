namespace targetNumber
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
            // 1. Read targetNumber
            Console.Write("Enter targetNumber: ");
            int targetNumber = int.Parse(Console.ReadLine());

            // 2a. Zolang iemand geen 0 invoert, vraag om een getal
            int count = 0;
            int inputNumber;
            bool isZero;
            do
            {
                Console.Write("Enter number: ");
                inputNumber = int.Parse(Console.ReadLine());

                // 2b. Hou bij hoe vaak het targetNumber is ingevuld
                if (inputNumber == targetNumber)
                {
                    count++;
                }
                isZero = (inputNumber == 0);
            }
            while (!isZero); // Gebruik een bool in je while condition, voor volledige punten
            // while (number != 0) geeft punten aftrek

            // 3. Display hoe vaak het targetNumber is ingevuld
            Console.WriteLine($"Count: {count}");
            Console.WriteLine("End of program");
        }
    }
}