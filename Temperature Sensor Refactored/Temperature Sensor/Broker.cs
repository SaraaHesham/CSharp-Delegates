using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Broker
    {
        // dictionary to store the subscribers and their events (subjects)
        private Dictionary<string,List<Action<TemperatureArgs>>> subscriberList = new ();

        // method to subscribe to an event
        public void Subscribe(string subject, Action<TemperatureArgs> action)
        {
            if (!subscriberList.ContainsKey(subject))
            {
                subscriberList[subject] = new List<Action<TemperatureArgs>>();
            }
            subscriberList[subject].Add(action);
        }
        public void Publish(string subject, TemperatureArgs message)
        {
            if (subscriberList.ContainsKey(subject))
            {
                foreach (var subscriber in subscriberList[subject])
                {
                    subscriber(message);
                }
            }
        }
    }
}
