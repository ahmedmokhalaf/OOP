using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Polymorphism
{
    class Employee
    {
        private string Name;
        private int Age;
        private string Address;
        private Salary EmSalary;

        public Employee(string name, int age, string address, Salary salary)
        {
            Name = name;
            Age = age;
            Address = address;
            EmSalary = salary;
        }
        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetAddress()
        {
            return Address;
        }
        public Salary GetSalary()
        {
            return EmSalary;
        }
    }
}
