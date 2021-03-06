using DesignPattern.Relationship.TestPrinter;

namespace DesignPattern.Relationship
{
    abstract class Teacher
    {
        protected string Name;

        public Teacher(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public string SayWelcome(Printer printer)
        {
            printer.SetStringToBePrinted(Name);
            return printer.PrintToScreen();
        }

        public abstract string AssignAHomeWork();

        public string EvaluateStudentHomeWork(Student student)
        {
            if (student.GetHomeWorkScore() > 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Success";
            }
            Console.ForegroundColor = ConsoleColor.Red;
            return "FAiled";
        }
    }
}
