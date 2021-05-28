using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryDataStreamer
{
    interface IBatteryInputGenerator
    {
        BmsBattery GetBatteryInputParameters();
        double GetBatteryTemperature();
        double GetBatteryChargeRate();
    }
}
