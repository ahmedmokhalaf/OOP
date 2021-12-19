using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Polymorphism
{
    class Salary
    {
        protected int salary;
        protected double tax;
        protected int overTime;

        public Salary(int salary, double tax, int overTime)
        {
            this.salary = salary;
            this.tax = tax;
            this.overTime = overTime;
        }

        public virtual double calculateSalary()
        {
            return salary - (salary * tax);
        }
        public  double calculateSalary(double extraTax)
        {
            return this.calculateSalary() - (salary * extraTax);
        }
    }
}
