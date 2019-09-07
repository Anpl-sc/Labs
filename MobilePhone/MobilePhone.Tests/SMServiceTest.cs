using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Services;

namespace MobilePhone.Tests {
    [TestClass]
    public class SMServiceTest {
        [TestMethod]
        public void ReceiveMessage() {
            string testMessage = "Test Message";
            string receivedMessage = "";
            SMService service = new SMService();
            service.SMSReceived += m => receivedMessage = m;
            service.ReceiveMessage(testMessage);

            Assert.AreEqual(testMessage, receivedMessage);
        }

        [TestMethod]
        public void SetFormatting() {
            string testMessage = "Test Message";
            string receivedMessage1 = "";
            string receivedMessage2 = "";
            SMService service = new SMService();
            SMService.SMSRecievedDelegate receive1 = m => receivedMessage1 = m;
            SMService.SMSRecievedDelegate receive2 = m => receivedMessage2 = m;
            service.SMSReceived += receive1;
            service.SetFormatting(4);
            service.ReceiveMessage(testMessage);
            service.SMSReceived -= receive1;
            service.SMSReceived += receive2;
            service.SetFormatting(0);
            service.ReceiveMessage(testMessage);
            string expectingString = "TEST MESSAGE";

            Assert.AreEqual(expectingString, receivedMessage1);
            Assert.AreEqual(testMessage, receivedMessage2);
        }
    }
}
