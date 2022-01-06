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
