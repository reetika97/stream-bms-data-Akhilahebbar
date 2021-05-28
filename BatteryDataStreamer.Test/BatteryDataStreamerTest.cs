using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BatteryDataStreamer.Test
{

    [TestClass]
    public class BatteryDataStreamerTest
    {
        [TestMethod]
        public void GetBatteryInputParameters_ValidReturnValue()
        {
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();

            BmsBattery result = batterygenerator.GetBatteryInputParameters();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetBatteryTemperature_ValidDataWithinRange()
        {
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();
            BmsBattery batteryParameter = new BmsBattery();
            batteryParameter.Temperature = batterygenerator.GetBatteryTemperature();
            Assert.IsTrue(batteryParameter.Temperature > Constants.MinTemperature && batteryParameter.Temperature < Constants.MaxTemperature);
        }
        [TestMethod]
        public void GetBatteryChargeRate_ValidDataWithinRange()
        {
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();
            BmsBattery batteryParameter = new BmsBattery();
            batteryParameter.ChargeRate = batterygenerator.GetBatteryChargeRate();
            Assert.IsTrue(batteryParameter.ChargeRate > Constants.MinChargeRate && batteryParameter.ChargeRate < Constants.MaxChargeRate);
        }
        [TestMethod]
        public void GenerateRandomNumber_ValidNumber()
        {
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();
            double resultValue = batterygenerator.GenerateRandomNumber(Constants.MinChargeRate, Constants.MaxChargeRate);
            Assert.IsNotNull(resultValue);
        }
    }
}

