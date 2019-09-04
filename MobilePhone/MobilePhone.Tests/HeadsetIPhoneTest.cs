using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Accessories.Audio;

namespace MobilePhone.Tests {
    [TestClass]
    public class HeadsetIPhoneTest {
        private FakeInOut fakeInOut;

        [TestInitialize]
        public void Create() {
            fakeInOut = new FakeInOut();
        }

        [TestMethod]
        public void Play() {
            HeadsetIPhone headsetIPhone = new HeadsetIPhone(fakeInOut);
            fakeInOut.FakeWrite = "";
            headsetIPhone.Play(new object());
            var expectedString = $"{nameof(HeadsetIPhone)} sound";

            Assert.AreEqual(expectedString, fakeInOut.FakeWrite);
        }

        [TestMethod]
        public void Record() {
            HeadsetIPhone headsetIPhone = new HeadsetIPhone(fakeInOut);
            var expectedString = $"{nameof(HeadsetIPhone)} recording";

            Assert.AreEqual(expectedString, headsetIPhone.Record());
        }
    }
}
