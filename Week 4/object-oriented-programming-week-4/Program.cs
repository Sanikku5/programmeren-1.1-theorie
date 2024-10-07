namespace object_oriented_programming_week_4
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
            Student testStudent = ReadStudent();
            testStudent.DisplayInfo();
            testStudent.UpdateFirstName("Robert");
            testStudent.DisplayInfo();
        }

        public Student ReadStudent()
        {
            Console.Write("Enter firstname: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter lastname: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter studentnumber: ");
            int studentNumber = int.Parse(Console.ReadLine());

            Student student = new Student(firstName, lastName, studentNumber);
            return student;
        }
    }
}