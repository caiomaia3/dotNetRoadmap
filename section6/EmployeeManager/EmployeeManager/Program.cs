using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBase employees = new EmployeeBase();
            Console.Write("How many employees will be registered? ");
            int nEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < nEmployees; i++)
            {
                Console.WriteLine("Employee#{0}:",i+1);
                Console.Write("Id:");
                int _id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                employees.AddEmployee(_id, name, salary);

            }
            Console.Write("Enter the employee id that will have salary increase:");
            int id = int.Parse(Console.ReadLine());
            if (employees.FindEmployee(id) == null)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage:");
                double rate = double.Parse(Console.ReadLine());
                employees.IncreaseSalary(id,rate);
                //Console.WriteLine(employees.ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Updated list of employees:");
            Console.WriteLine(employees);
        }
    }
}
