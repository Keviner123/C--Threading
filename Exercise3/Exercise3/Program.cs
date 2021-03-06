﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer(); 
            Thread thermometerThread = new Thread(new ThreadStart(thermometer.Alarm));
            thermometerThread.Start(); 
            while (true)
            {
                if (!thermometerThread.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
                Thread.Sleep(10000);
            }
        }
    }
}
