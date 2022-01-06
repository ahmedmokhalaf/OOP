namespace DesignPattern.Polymorphism
{
    class OrganizeationSalary : Salary
    {
        private double organiztionTax;
        public OrganizeationSalary(int salary, double tax, int overTime, double organiztionTax) : base(salary, tax, overTime)
        {
            this.organiztionTax = organiztionTax;
        }
        public override double calculateSalary()
        {
            return salary - (salary * tax) - (salary * organiztionTax);
        }
    }
}
