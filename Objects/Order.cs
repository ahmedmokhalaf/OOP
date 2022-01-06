using DesignPattern.Abstraction;
using DesignPattern.Interfaces;

namespace DesignPattern.Objects
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

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            WeightHolder weightHolder = car as WeightHolder;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (weightHolder != null)
            {
                weightHolder.LeftCargo();
                return $"I am moving From {Source} To {Target} to delivered a package of {Weight} K.G Using Weight Holder";
            }

            return $"I am moving From {Source} To {Target} to delivered a package of {Weight} K.G";
        }
    }
}
