using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Alarm
    {
        public void SubscribeToTemperature(Broker broker)
        {
            broker.Subscribe("TemperatureChanged", FireAlarm);
        }
        public Alarm(double intialValue) 
        {
            AlarmValue = intialValue;
        }
        private double AlarmValue { get; set; }
        public void SetAlarmValue(double newalarmValue)
        {
            AlarmValue = newalarmValue;
        }
        public void FireAlarm(TemperatureArgs args)
        {
            if (args.Temperature > AlarmValue)
            {
                Console.WriteLine($"Take Care, The Temperature Now Is {args.Temperature} Is Exceeding The Authorized Temperature Value Which Is {AlarmValue}");
            }
        }
    }
}
