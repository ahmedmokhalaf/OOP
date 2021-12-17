using DesignPattern;
// See https://aka.ms/new-console-template for more information

Microwave microwave = new Microwave(20,"TestP",50);
Console.WriteLine(microwave.deFreeze());

// Example For Abstraction.
BMW bMW = new BMW(500,4,"Back","Red");
BMW newBMW = new BMW(300,2,"FRONT","BLACK");
TruckXT truck = new TruckXT(300,2,"Test","WHITE");
// Example For Encapsulation.
CarDashboard dashboard = new CarDashboard(200,100,500);
truck.InstallDashboard(dashboard);
Console.WriteLine(truck.CarInfo());
//

Order order1 = new Order("Cairo","Alex",200);
Order order2 = new Order("Alex","Libya",800);
Order order3 = new Order("Hind","USA",2800);

Console.WriteLine(order1.DeliverOrder(newBMW));
Console.WriteLine(order2.DeliverOrder(bMW));
Console.WriteLine(order3.DeliverOrder(truck));