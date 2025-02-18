using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Display
    {
        public void SubscribeToTemperature(Broker broker)
        {
            broker.Subscribe("TemperatureChanged", DisplayTemperature);
        }
        public void DisplayTemperature(TemperatureArgs args)
        {
            Console.WriteLine($"The Temperature Now Is : {args.Temperature}");
        }
    }
}
