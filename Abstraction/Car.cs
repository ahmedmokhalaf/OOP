using DesignPattern.Encapsulation;

namespace DesignPattern.Abstraction
{
    abstract class Car
    {
        protected int speed;
        protected int numberOfDoors;
        protected string gearBoxSystem;
        protected string color;
        protected bool TurnStatus = false;
        private CarDashboard Dashboard;

#pragma warning disable CS8618 // Non-nullable field 'Dashboard' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        protected Car(
#pragma warning restore CS8618 // Non-nullable field 'Dashboard' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
            int speed, int numberOfDoors, string gearBoxSystem, string color)
        {
            this.speed = speed;
            this.numberOfDoors = numberOfDoors;
            this.gearBoxSystem = gearBoxSystem;
            this.color = color;
        }

        public abstract int Move();
        public abstract bool TurnOn();
        public abstract bool TurnOFF();
        public abstract bool Accelerate(int speed);
        public abstract bool Park();

        public void InstallDashboard(CarDashboard dashboard)
        {
            Dashboard = dashboard;
        }
        public string CarInfo()
        {
            if (!String.IsNullOrWhiteSpace(Dashboard.ReadDashboard()))
            {
                return $" The Speed {this.speed} \n More Info ...\n{Dashboard.ReadDashboard()}";
            }
            else
            {
                return $"The Speed {this.speed} \n";
            }
        }
    }
}
