using DesignPattern.Encapsulation;
using DesignPattern.Objects;
using DesignPattern.Polymorphism;
using DesignPattern.Relationship;
using DesignPattern.Relationship.Aggregation;
using DesignPattern.Relationship.Composition;
using DesignPattern.Relationship.Teachers;
using DesignPattern.Relationship.TestPrinter;
using System.Text;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Object Example ***");
Console.ResetColor();
Microwave microwave = new Microwave(20, "TestP", 50);
Console.WriteLine(microwave.deFreeze());
Console.WriteLine("================================================================================");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Abstraction Example ***");
Console.ResetColor();
BMW bMW = new BMW(500, 4, "Back", "Red");
BMW newBMW = new BMW(300, 2, "FRONT", "BLACK");
TruckXT truck = new TruckXT(300, 2, "Test", "WHITE");
Console.WriteLine("================================================================================");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Encapsulation Example ***");
Console.ResetColor();
CarDashboard dashboard = new CarDashboard(200, 100, 500);
truck.InstallDashboard(dashboard);
Console.WriteLine(truck.CarInfo());
Console.WriteLine("================================================================================");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Using Abstraction && Encapsulation On Example ***");
Console.ResetColor();
Order order1 = new Order("Cairo", "Alex", 200);
Order order2 = new Order("Alex", "Libya", 800);
Order order3 = new Order("Hind", "USA", 2800);
Console.WriteLine("BMW :" + order2.DeliverOrder(bMW));
Console.WriteLine("New BMW :" + order1.DeliverOrder(newBMW));
Console.WriteLine("*** Here Using truck With IWeightHolder And Install DashBoard ***");
Console.WriteLine("Truck" + order3.DeliverOrder(truck));
Console.WriteLine("================================================================================");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" *** Polymorphism *** ");
Console.WriteLine(" *** Static Polymorphism *** ");
Console.ResetColor();

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

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** OOP Relationship ***");
Console.WriteLine("*** === Association ===  ***");
Console.WriteLine("*** === Two Ways Direction ===  ***");
Console.ResetColor();
Teacher Mona = new ScienceTeacher("Mona");
Teacher Hend = new MathTeacher("Hend");
Student Sama = new Student("Sama");

Sama.AssignATempTeacher(Mona);

Console.WriteLine(Sama.GetName() + " Was Assigned This By " + Mona.GetName() + " The Result Of HomeWork :  " + Sama.GetScore() + "  ==> " + Mona.EvaluateStudentHomeWork(Sama));
Console.ResetColor();

Sama.AssignATempTeacher(Hend);
Console.WriteLine(Sama.GetName() + " Was Assigned This By " + Hend.GetName() + " The Result Of HomeWork :  " + Sama.GetScore() + "  ==> " + Hend.EvaluateStudentHomeWork(Sama));
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** === One Ways Direction ===  ***");
Console.ResetColor();
HtmlPrinter PHtml = new HtmlPrinter();
PlainPrinter PPlain = new PlainPrinter();
Console.WriteLine("HTML Printer : " + Mona.SayWelcome(PHtml));
Console.WriteLine("Plain Printer : " + Hend.SayWelcome(PPlain));
PHtml.SetStringToBePrinted("Test Text");
Console.WriteLine("HTML Printer : " + PHtml.PrintToScreen());
Console.WriteLine("--------------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Aggregation ***");
Console.ResetColor();
Developer DOne = new Developer("Dev ONE");
Developer DTwo = new Developer("Dev Two");
Developer DThree = new Developer("Dev Three");
Developer DFour = new Developer("Dev Four");
HashSet<Developer> Developers = new HashSet<Developer>();
Developers.Add(DOne);
Developers.Add(DOne);
Developers.Add(DOne);
Developers.Add(DTwo);
Developers.Add(DTwo);
Developers.Add(DTwo);
Developers.Add(DThree);
Developers.Add(DThree);
Developers.Add(DThree);
Developers.Add(DFour);
Project XProject = new Project("X Project", DateOnly.FromDateTime(DateTime.Now), Developers);
Console.WriteLine(XProject.ShowProjectInformation());
Console.WriteLine("--------------------------------------------------------------------------------");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("*** Composition ***");
Console.ResetColor();

Room room1 = new Room("White", 50);
Room room2 = new Room("White", 90);
Room room3 = new Room("White", 30);
Room room4 = new Room("White", 20);
List<Room> Rooms = new List<Room>() { room1, room2, room3, room4 };
House house = new House(Rooms);
Console.WriteLine(house);
Console.WriteLine("--------------------------------------------------------------------------------");
RAM ram = new RAM(50);
CPU cpu = new CPU(5);
ComputerMachine machine = new ComputerMachine(cpu, ram);
Console.WriteLine(machine.CMDashBorad());
Console.WriteLine("================================================================================");
Console.WriteLine("================================================================================");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Inheritance IS-A \t Manger IS-A Employee");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Aggregation HAS-A \t Project HAS-A Developer");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Composition PART-OF \t Room PART-OF House");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("====================================== *** END *** ====================================== ");
Console.ResetColor();
Console.OutputEncoding = Encoding.UTF8;

Console.ReadLine();
