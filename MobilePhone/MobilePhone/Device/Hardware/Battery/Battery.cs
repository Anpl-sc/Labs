using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Battery {
    public class Battery{
        public int Capacity { get; private set; }
        public int ChargingTime { get; private set; }

        public Battery(int capacity, int chargingTime) {
            Capacity = capacity;
            ChargingTime = chargingTime;
        }

        public void PowerSupply(IPowerProfile powerProfile) {
            Console.WriteLine("Power supplying with voltage " + powerProfile.Voltage + ", and currency " + powerProfile.OutputCurrency +"\n");
        }

        public override string ToString() {
            return "Device battery, Capacity " + Capacity + ", ChargingTime " + ChargingTime;
        }
    }
}
