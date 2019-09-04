using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Accessories.Usb;

namespace MobilePhone.Tests {
    [TestClass]
    public class ChargerTest {
        [TestMethod]
        public void PowerSupply() {
            FakeInOut fakeInOut = new FakeInOut();
            Charger headsetIPhone = new Charger(fakeInOut);
            fakeInOut.FakeWrite = "";
            headsetIPhone.PowerSupply(new object());
            var expectedString = $"{nameof(Charger)} connected to USB, charging mobile device";

            Assert.AreEqual(expectedString, fakeInOut.FakeWrite);
        }
    }
}
