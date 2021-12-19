using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Encapsulation
{
    class CarDashboard
    {
        protected int OilLevel;
        protected int FuelLevel;
        protected int AirPressure;

        public CarDashboard(int oilLevel, int fuelLevel, int airPressure)
        {
            OilLevel = oilLevel;
            FuelLevel = fuelLevel;
            AirPressure = airPressure;
        }

        public string ReadDashboard()
        {
            return $"Showing The Following Analysis \n " +
                $" \t\t Fuel: {FuelLevel} \n" +
                $" \t\t Oil : {OilLevel} \n" +
                $" \t\t AirPressure: {AirPressure} \n";

        }
    }
}
