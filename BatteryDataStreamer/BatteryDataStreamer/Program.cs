using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatteryDataStreamer
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBatteryData();
        }
        public static void GetBatteryData()
        {
            BmsBattery batteryParameter = new BmsBattery();
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();
            for (int i = 0; i <= 15; i++)
            {
                Thread.Sleep(300);
                batteryParameter = batterygenerator.GetBatteryInputParameters();
                Console.WriteLine("Temperature:" + batteryParameter.Temperature + ",ChargeRate:" + batteryParameter.ChargeRate);
            }
            Console.ReadLine();

        }
    }
}
