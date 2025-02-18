namespace Temperature_Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker();
            Sensor sensor = new Sensor(broker); //publisher
            Display display = new Display(); //subscriber
            Alarm alarm = new Alarm(20); //subscriber

            //subscribe to the event
            display.SubscribeToTemperature(broker);
            alarm.SubscribeToTemperature(broker);

            //sensor.SensorValueChanged += display.DisplayTemperature;
            //sensor.SensorValueChanged += alarm.FireAlarm;

            while (true)
            {
                Console.WriteLine("Welcome To My Temperature System");
                Console.WriteLine("1-Set The Temperature");
                Console.WriteLine("2-Set The Alarm Value 'It's Default Value Is 20' ");
                Console.WriteLine("3-Exit");

                Console.Write("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter The Temperature In Degrees: ");
                        double temperature = double.Parse(Console.ReadLine());
                        sensor.changeTemperature(temperature);
                        break;
                    case 2:
                        Console.Write("Enter The Alarm Value: ");
                        double alarmValue = double.Parse(Console.ReadLine());
                        alarm.SetAlarmValue(alarmValue);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}
