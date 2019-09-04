using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary;
using MobilePhoneLibrary.Accessories.Audio;
using MobilePhoneLibrary.Accessories.Usb;

namespace MobilePhone.Tests {
    [TestClass]
    public class SimCorpMobileTest {
        private SimCorpMobile simCorpMobile;
        private FakeInOut fakeInOut;

        [TestInitialize]
        public void Create() {
            fakeInOut = new FakeInOut();
            simCorpMobile = new SimCorpMobile(fakeInOut);
        }

        [TestMethod]
        public void SetAudioAccessory() {
            fakeInOut.Selected = 4;
            fakeInOut.FakeWrite = "";
            simCorpMobile.SetAudioAccessory();
            string expectedChoise = "Audio Accessory:";
            string[] expectedVariants = { nameof(HeadsetIPhone), nameof(NoNameHeadset), nameof(PortableSpeaker), nameof(SamsungHeadphones) };
            string expectedOutput = $"Selected {nameof(SamsungHeadphones)}" +
                                    $"{nameof(SamsungHeadphones)} sound" +
                                    $"Record function is not available\r\n";

            Assert.AreEqual(expectedChoise, fakeInOut.InputChoise);
            Assert.AreEqual(expectedVariants.ToString(), fakeInOut.InputVariants.ToString());
            Assert.AreEqual(expectedOutput, fakeInOut.FakeWrite);
        }

        [TestMethod]
        public void SetUsbAccessory() {
            fakeInOut.Selected = 3;
            fakeInOut.FakeWrite = "";
            simCorpMobile.SetUsbAccessory();
            string expectedChoise = "USB Accessory:";
            string[] expectedVariants = { nameof(Charger), nameof(FlashLight), nameof(UsbDisplay) };
            string expectedOutput = $"Selected {nameof(UsbDisplay)}" +
                                    $"{nameof(UsbDisplay)} connected to USB, consuming power" +
                                    $"Send data to {nameof(UsbDisplay)}";

            Assert.AreEqual(expectedChoise, fakeInOut.InputChoise);
            Assert.AreEqual(expectedVariants.ToString(), fakeInOut.InputVariants.ToString());
            Assert.AreEqual(expectedOutput, fakeInOut.FakeWrite);
        }
    }
}
