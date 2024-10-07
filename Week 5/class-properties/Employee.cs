using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_properties
{
    public class Employee
    {
        private double _salary; // Backing field for Salary
        public string FirstName { get; }
        public string LastName { get; private set; }  // alleen "set;" is een public set, daarom staat "private" ervoor
        public string Department { get; private set; }
        public double Salary
        {
            get { return _salary; }
            private set
            {
                if (value < _salary) // If new value is higher than old value
                    return; // Silent ignore
                else if (value > _salary * 1.1) // If the new value is 110% or more of the old value
                    _salary *= 1.1; // Set it to 110%, it can't go bigger than that
                else
                    _salary = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Employee(string firstName, string lastName, string department, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            _salary = salary;
            // Conventie om de backing field van de property aan te passen in de constructor, en niet de property zelf
        }

        public void IncreaseSalary(double increase)
        {
            Salary += increase;
        }

        public void ChangeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void ChangeDepartment(string newDepartment)
        {
            Department = newDepartment;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Works for: {Department}");
            Console.WriteLine($"Arbeidsloon: {Salary}");
            Console.WriteLine();
        }
    }
}
