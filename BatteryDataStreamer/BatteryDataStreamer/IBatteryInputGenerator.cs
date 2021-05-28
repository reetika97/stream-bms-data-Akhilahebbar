using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryDataStreamer
{
   public interface IBatteryInputGenerator
    {
        BmsBattery GetBatteryInputParameters();
        double GetBatteryTemperature();
        double GetBatteryChargeRate();
       double GenerateRandomNumber(double minValue, double maxValue);
    }
}
