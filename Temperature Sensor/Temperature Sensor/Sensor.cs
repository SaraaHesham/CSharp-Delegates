using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Sensor
    {
        //Declare event
        public event EventHandler<TemperatureArgs> SensorValueChanged;
        private double currentTemperature { get; set; }
        public void changeTemperature(double newTemperature)
        {
            currentTemperature = newTemperature;
            //Raise event
            SensorValueChanged?.Invoke(this, new TemperatureArgs(newTemperature));
        }
    }
}
