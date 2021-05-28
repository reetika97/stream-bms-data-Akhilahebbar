using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatteryDataStreamer
{
    class BatteryInputGenerator: IBatteryInputGenerator
    {
        private readonly Random randomNumberGenerator = new Random();
        public BmsBattery GetBatteryInputParameters()
        {
            BmsBattery BatteryProperties = new BmsBattery();
            BatteryProperties.Temperature = GetBatteryTemperature();
            BatteryProperties.ChargeRate = GetBatteryChargeRate();
            return BatteryProperties;
        }
        public double GetBatteryTemperature()
        {
            double Min = Constants.MinTemperature;
            double Max = Constants.MaxTemperature;
            Thread.Sleep(500);
            System.Random random = new System.Random();
            double TempValue = Math.Round((random.NextDouble() * (Max - Min) + Min),2);
            return TempValue;
        }
        public double GetBatteryChargeRate()
        {
            double Min = Constants.MinTemperature;
            double Max = Constants.MaxTemperature;
            Thread.Sleep(500);
            System.Random random = new System.Random();
            double ChargeRateValue = Math.Round((random.NextDouble() * (Max - Min) + Min),2);
            return ChargeRateValue;
        }
    }
}
