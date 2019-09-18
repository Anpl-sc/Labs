using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Hardware.Battery;

namespace MobilePhone.Tests {
    [TestClass]
    public class BatteryTest {
        [TestMethod]
        public void StartCharge() {
            int maxCharge = 100;

            FakeInOut fakeInOut = new FakeInOut();
            int capacity = 5000;
            int chargingTime = 60;

            int charge = 0;
            Battery battery = new Battery(capacity,chargingTime,fakeInOut);
            battery.ShowCharge += (s, c) => charge = c;

            battery.StartCharge(1);
            if (charge == 100) {
                battery.StartCharge(1);
            }

            Assert.AreEqual(charge, maxCharge);
        }

        [TestMethod]
        public void Discharge() {
            int minCharge = 0;

            FakeInOut fakeInOut = new FakeInOut();
            int capacity = 5000;
            int chargingTime = 60;

            int charge = 50;
            Battery battery = new Battery(capacity, chargingTime, fakeInOut);
            battery.ShowCharge += (s, c) => {
                charge = c;
                if (c <= 0 ) { battery.CanDischarge = false; }
            };

            battery.Discharge(1);
            if (charge == 0) {
                battery.CanDischarge = true;
                battery.Discharge(1);
            }

            Assert.AreEqual(charge, minCharge);
        }
    }
}
