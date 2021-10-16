using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManager
{
    class EmployeeBase
    {
        private List<Employee> employees = new List<Employee>();

        public Employee FindEmployee(int id)
        {
            Employee employee = new Employee();
            return employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddEmployee(int id, string name, double salary)
        {
            Employee employee = new Employee(id, name, salary);
            employees.Add(employee);
            //Console.WriteLine("The database has {0} employees.",employees.Count);
        }
        public override string ToString()
        {
            string msg = "";
            foreach (Employee employee in employees)
            {
                msg += employee.ToString() + "\n";
            }
            return msg;
        }

        public void IncreaseSalary(int id, double rate)
        {
            this.employees.Find(x => x == FindEmployee(id)).Salary *= (100+rate)/100;
        }
    }
}
