using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class TemperatureArgs
    {
        public double Temperature { get; set; }
        public TemperatureArgs(double temperature) 
        {
            Temperature = temperature;
        }
    }
}
