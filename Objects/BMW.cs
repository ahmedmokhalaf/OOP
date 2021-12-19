using DesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Objects
{
    class BMW : Car
    {
        public BMW(int speed, int numberOfDoors, string gearBoxSystem, string color) : base(speed, numberOfDoors, gearBoxSystem, color)
        {
        }

        

        public override bool Accelerate(int speed)
        {
            this.speed = speed;
            return true;
        }

        public override int Move()
        {
            return this.speed;
        }

        public override bool Park()
        {
            return true;
        }

        public override bool TurnOFF()
        {
            this.TurnStatus = false;
            return true;
        }

        public override bool TurnOn()
        {
            this.TurnStatus = true;
            return true;

        }
    }
}
