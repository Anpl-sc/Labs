﻿namespace MobilePhoneLibrary.Hardware.Battery {
    public class Battery{
        private IUserInOut userInOut;

        public int Capacity { get; }
        public int ChargingTime { get; }

        public Battery(int capacity, int chargingTime, IUserInOut userInOut) {
            Capacity = capacity;
            ChargingTime = chargingTime;
            this.userInOut = userInOut;
        }

        public void PowerSupply(IPowerProfile powerProfile) {
            userInOut.WriteLine("Power supplying with voltage " + powerProfile.Voltage + ", and currency " + powerProfile.OutputCurrency +"\n");
        }

        public override string ToString() {
            return "Device battery, Capacity " + Capacity + ", ChargingTime " + ChargingTime;
        }
    }
}