namespace DesignPattern.Relationship
{
    class Student
    {
        private string Name;
        private string HomeWorke;
        protected int HomeWorkScore;

#pragma warning disable CS8618 // Non-nullable field 'HomeWorke' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public Student(string name)
#pragma warning restore CS8618 // Non-nullable field 'HomeWorke' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
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
            HomeWorkScore = new Random().Next(20, 60);
            HomeWorke = teacher.AssignAHomeWork();
        }

        public int GetHomeWorkScore()
        {
            return HomeWorkScore;
        }

    }
}
