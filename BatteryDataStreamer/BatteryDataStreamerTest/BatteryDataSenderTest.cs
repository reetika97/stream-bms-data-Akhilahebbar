
using BatteryDataStreamer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BatteryDataStreamerTest
{
    [TestClass]
    public class BatteryDataSenderTest
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
            Assert.IsTrue(batteryParameter.Temperature>Constants.MinTemperature && batteryParameter.Temperature < Constants.MaxTemperature);
        }
        [TestMethod]
        public void GetBatteryChargeRate_ValidDataWithinRange()
        {
            IBatteryInputGenerator batterygenerator = new BatteryInputGenerator();
            BmsBattery batteryParameter = new BmsBattery();
            batteryParameter.ChargeRate = batterygenerator.GetBatteryChargeRate();
            Assert.IsTrue(batteryParameter.ChargeRate > Constants.MinChargeRate && batteryParameter.ChargeRate < Constants.MaxChargeRate);
        }
    }
}
