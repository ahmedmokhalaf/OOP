using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Relationship.Teachers
{
    class MathTeacher : Teacher
    {
        public MathTeacher(string name) : base(name)
        {
        }

        public override string AssignAHomeWork()
        {
            return " Calculate the sum of 100 and 44 ";
        }
    }
}
