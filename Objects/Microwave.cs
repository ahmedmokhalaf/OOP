using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Objects
{
    public class Microwave
    {
        private int temp;
        private string program;
        private int time;

        public Microwave(int _temp , string _program, int _time)
        {
            temp = _temp;
            program = _program;
            time = _time;
        }
        public string deFreeze()
        {
            TurnOnHeatingSystem();
            LoadingDeFreezingProgram();
            SetTimer();
            return $"I am De-Freezing At {temp} using the program {program}";
        }

        private string TurnOnHeatingSystem()
        {
            return "Starting Heating System";
        }

        private string LoadingDeFreezingProgram()
        {
            return $"Loading Program {program}";
        }

        private string SetTimer()
        {
            return $"Setting De-Freezing Time to {time} Seconds";
        }
    }
}
