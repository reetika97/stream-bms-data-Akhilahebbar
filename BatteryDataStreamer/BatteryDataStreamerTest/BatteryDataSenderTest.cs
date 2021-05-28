using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatteryDataStreamer
{
    public class BatteryInputGenerator: IBatteryInputGenerator
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
            Thread.Sleep(500);
            double TempValue = GenerateRandomNumber(Constants.MinTemperature, Constants.MaxTemperature);
            return TempValue;
        }
        public double GetBatteryChargeRate()
        {
            Thread.Sleep(500);
            double ChargeRateValue = GenerateRandomNumber(Constants.MinChargeRate, Constants.MaxChargeRate);
            return ChargeRateValue;
        }
        public double GenerateRandomNumber(double minValue,double maxValue)
        {
            System.Random random = new System.Random();
            double RandomValue = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
            return RandomValue;
        }
    }
}
