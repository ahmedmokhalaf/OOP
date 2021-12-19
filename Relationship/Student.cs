using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Relationship
{
    class Student
    {
        private string Name;
        private string HomeWorke;
        protected int HomeWorkScore;

        public Student(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public int GetScore()
        {
            return HomeWorkScore;
        }
        public void AssignATempTeacher(Teacher teacher)
        {
            HomeWorkScore = new Random().Next(20,60);
            HomeWorke = teacher.AssignAHomeWork();
        }

        public int GetHomeWorkScore()
        {
            return HomeWorkScore;
        }

    }
}
