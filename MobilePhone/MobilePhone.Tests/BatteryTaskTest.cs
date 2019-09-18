using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Hardware.Battery;

namespace MobilePhone.Tests {
    [TestClass]
    public class BatteryTaskTest {
        [TestMethod]
        public void StartChargeTask() {
            int maxCharge = 100;
            int resultCharge = 0;

            FakeInOut fakeInOut = new FakeInOut();
            int capacity = 5000;
            int chargingTime = 60;

            int charge = 99;
            bool isCall = false;
            Battery battery = new BatteryTask(capacity, chargingTime, fakeInOut);
            battery.ShowCharge += (s, c) => {
                resultCharge = c;
                isCall = true;
            };
            battery.Charge = charge;

            battery.StartCharge(1);
            for (int i = 0; (i < 100)&&(!isCall); i++) {
                Thread.Sleep(2);
            }

            Assert.IsTrue(isCall);
            Assert.AreEqual(resultCharge, maxCharge);
        }

        [TestMethod]
        public void DischargeTask() {
            int minCharge = 0;
            int resultCharge = 100;

            FakeInOut fakeInOut = new FakeInOut();
            int capacity = 5000;
            int chargingTime = 60;

            int charge = 1;
            bool isCall = false;
            Battery battery = new BatteryTask(capacity, chargingTime, fakeInOut);
            battery.ShowCharge += (s, c) => {
                resultCharge = c;
                if (c <= 0) { battery.CanDischarge = false; }
                isCall = true;
            };
            battery.Charge = charge;

            battery.Discharge(1);
            for (int i = 0; (i < 100) && (!isCall); i++) {
                Thread.Sleep(2);
            }

            Assert.IsTrue(isCall);
            Assert.AreEqual(resultCharge, minCharge);
        }
    }
}
