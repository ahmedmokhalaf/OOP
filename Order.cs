using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Order
    {
        private string Source;
        private string Target;
        private int Weight;

        public Order(string source, string target, int weight)
        {
            Source = source;
            Target = target;
            Weight = weight;
        }

        public string DeliverOrder(Car car)
        {
            car.TurnOn();
            car.Move();
            car.Accelerate(120);
            car.Park();
            car.TurnOFF();

            WeightHolder weightHolder = car as WeightHolder;
            if (weightHolder != null)
            {
                weightHolder.LeftCargo();
                return $"I am moving From {Source} To {Target} to delivered a package of {Weight} K.G Using Weight Holder";
            }

            return $"I am moving From {Source} To {Target} to delivered a package of {Weight} K.G";
        }
    }
}
