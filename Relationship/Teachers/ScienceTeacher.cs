using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Relationship.Teachers
{
    class ScienceTeacher : Teacher
    {
        public ScienceTeacher(string name) : base(name)
        {
        }

        public override string AssignAHomeWork()
        {
            return " PLease Prepare a research on pLante ";
        }
    }
}
