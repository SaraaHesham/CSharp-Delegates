using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Sensor
    {
        private Broker _Broker;
        public Sensor(Broker broker) 
        {
            _Broker = broker;
        }

        //Declare event
        public event EventHandler<TemperatureArgs> SensorValueChanged;
        private double currentTemperature { get; set; }
        public void changeTemperature(double newTemperature)
        {
            currentTemperature = newTemperature;
            //Raise event
            _Broker.Publish("TemperatureChanged", new TemperatureArgs(newTemperature));
            
            //SensorValueChanged?.Invoke(this, new TemperatureArgs(newTemperature));
        }
    }
}
