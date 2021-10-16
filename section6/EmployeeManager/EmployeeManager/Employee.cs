using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeManager
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public double Salary { get; set; }

        public Employee(){}
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(int id)
        {
            const double increaseFactor = 1.1;
            Salary = increaseFactor*Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
