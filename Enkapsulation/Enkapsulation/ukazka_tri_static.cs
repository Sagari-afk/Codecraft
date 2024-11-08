using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulation
{
    public class Employee
    {
        public string id;
        public string name;

        public Employee() { }

        public Employee(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
        public static int getEmployeeCounter()
        {
            return employeeCounter;
        }
    }

    //class MainClass : Employee
    //{
    //    static void Main()
    //    {
            
    //        Employee e = new Employee("Anna", "q123d");
    //        Employee.AddEmployee();
    //        Employee.AddEmployee();

    //        Console.WriteLine($"Name: {e.name}");
    //        Console.WriteLine($"ID:   {e.id}");
    //        Console.WriteLine($"New Number of Employees: " +
    //            $"{Employee.getEmployeeCounter()}");
    //    }
    //}
}
