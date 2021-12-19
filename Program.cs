using DesignPattern;
using DesignPattern.Encapsulation;
using DesignPattern.Objects;
using DesignPattern.Polymorphism;
using DesignPattern.Relationship;
using DesignPattern.Relationship.Teachers;
using DesignPattern.Relationship.TestPrinter;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Object Example ***");
Microwave microwave = new Microwave(20, "TestP", 50);
Console.WriteLine(microwave.deFreeze());
Console.WriteLine("================================================================================");
Console.WriteLine("*** Abstraction Example ***");
BMW bMW = new BMW(500, 4, "Back", "Red");
BMW newBMW = new BMW(300, 2, "FRONT", "BLACK");
TruckXT truck = new TruckXT(300, 2, "Test", "WHITE");
Console.WriteLine("================================================================================");
Console.WriteLine("*** Encapsulation Example ***");
CarDashboard dashboard = new CarDashboard(200, 100, 500);
truck.InstallDashboard(dashboard);
Console.WriteLine(truck.CarInfo());
Console.WriteLine("================================================================================");
Console.WriteLine("*** Using Abstraction && Encapsulation On Example ***");
Order order1 = new Order("Cairo", "Alex", 200);
Order order2 = new Order("Alex", "Libya", 800);
Order order3 = new Order("Hind", "USA", 2800);
Console.WriteLine("BMW :" + order2.DeliverOrder(bMW));
Console.WriteLine("New BMW :" + order1.DeliverOrder(newBMW));
Console.WriteLine("*** Here Using truck With IWeightHolder And Install DashBoard ***");
Console.WriteLine("Truck" + order3.DeliverOrder(truck));
Console.WriteLine("================================================================================");
Console.WriteLine(" *** Polymorphism *** ");
Console.WriteLine(" *** Static Polymorphism *** ");
Salary ahmedSalary = new Salary(4500, 0.2, 2);
Employee ahmed = new Employee("Ahmed", 31, "Cairo", ahmedSalary);
Console.WriteLine("Salary :" + ahmed.GetSalary().calculateSalary());
Console.WriteLine("Salary :" + ahmed.GetSalary().calculateSalary(0.1));
Console.WriteLine(" *** Dynamic Polymorphism *** ");
Console.WriteLine(" *** Secret Key Word In Dynamic Polymorphism IS  virtual And override ***");
OrganizeationSalary salary = new OrganizeationSalary(4500, 0.2, 2, 0.15);
Employee ali = new Employee("Ali", 31, "Cairo", salary);
Console.WriteLine("OrganizeationSalary :" + ali.GetSalary().calculateSalary());
Console.WriteLine("OrganizeationSalary :" + ali.GetSalary().calculateSalary(0.1));
Console.WriteLine("================================================================================");
Console.WriteLine("*** OOP Relationship ***");
Console.WriteLine("*** === Association ===  ***");
Console.WriteLine("*** === Two Ways Direction ===  ***");
Teacher Mona = new ScienceTeacher("Mona");
Teacher Hend = new MathTeacher("Hend");
Student Sama = new Student("Sama");

Sama.AssignATempTeacher(Mona);

Console.WriteLine(Sama.GetName() + " Was Assigned This By " + Mona.GetName() + " The Result Of HomeWork :  " + Sama.GetScore() + "  ==> " + Mona.EvaluateStudentHomeWork(Sama));
Console.ResetColor();

Sama.AssignATempTeacher(Hend);
Console.WriteLine(Sama.GetName() + " Was Assigned This By " + Hend.GetName() + " The Result Of HomeWork :  " + Sama.GetScore() + "  ==> "+Hend.EvaluateStudentHomeWork(Sama));
Console.ResetColor();

Console.WriteLine("*** === One Ways Direction ===  ***");
HtmlPrinter PHtml = new HtmlPrinter();
PlainPrinter PPlain = new PlainPrinter();
Console.WriteLine("HTML Printer : " + Mona.SayWelcome(PHtml));
Console.WriteLine("Plain Printer : " + Hend.SayWelcome(PPlain));
PHtml.SetStringToBePrinted("Test Text");
Console.WriteLine("HTML Printer : " + PHtml.PrintToScreen());
Console.WriteLine("================================================================================");