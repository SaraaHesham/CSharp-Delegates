﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Display
    {
        public void DisplayTemperature(object? sender, TemperatureArgs args)
        {
            Console.WriteLine($"The Temperature Now Is : {args.Temperature}");
        }
    }
}
