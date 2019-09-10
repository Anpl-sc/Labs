using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Services;

namespace MobilePhone.Tests {
    [TestClass]
    public class MessageStorageTest {
        [TestMethod]
        public void AddMessage() {
            PhoneMessage testMessage = new PhoneMessage( new Contact("Nick", 0), "Test Message", DateTime.Now );
            PhoneMessage receivedMessage = new PhoneMessage(new Contact("Nick", 0), "Received Message", DateTime.Now);

            MessageStorage storage = new MessageStorage();
            storage.SMSShow += m => receivedMessage = m[0];
            storage.AddMessage(testMessage);

            Assert.AreEqual(testMessage, receivedMessage);
        }

        [TestMethod]
        public void RemoveMessage() {
            PhoneMessage testMessage = new PhoneMessage(new Contact("Nick", 0), "Test Message", DateTime.Now);
            PhoneMessage receivedMessage = new PhoneMessage(new Contact("Nick", 0), "Received Message", DateTime.Now);

            MessageStorage storage = new MessageStorage();
            storage.SMSShow += m => receivedMessage = m[0];
            storage.AddMessage(testMessage);
            storage.Remove(receivedMessage);

            Assert.AreEqual(0, storage.GetMessages().Count);
        }

        [TestMethod]
        public void SetFormatting() {
            string testString = "Test Message";
            PhoneMessage testMessage = new PhoneMessage(new Contact("Nick", 0), testString, DateTime.Now);
            PhoneMessage receivedMessage = new PhoneMessage(new Contact("Nick", 0), "Received Message", DateTime.Now);

            MessageStorage storage = new MessageStorage();
            MessageStorage.SMSShowDelegate receive = m => receivedMessage = m[0];
            storage.SMSShow += receive;

            storage.SetViewSettings(new MessagesSettings( 4, null, "", false, DateTime.Now, false, DateTime.Now, false));
            storage.AddMessage(testMessage);
            string receivedString = receivedMessage.FormatText;
            storage.SetViewSettings(new MessagesSettings(0, null, "", false, DateTime.Now, false, DateTime.Now, false));
            string expectingString = "TEST MESSAGE";

            Assert.AreEqual(expectingString, receivedString);
            Assert.AreEqual(testString, receivedMessage.FormatText);
        }

        [TestMethod]
        public void ApplyFiltersSeparate() {
            PhoneMessage testMessage1 = new PhoneMessage(new Contact("Nick", 0), "Test Message1", DateTime.Now);
            PhoneMessage testMessage2 = new PhoneMessage(new Contact("Nick", 1), "Test Message2", DateTime.MaxValue);
            PhoneMessage testMessage3 = new PhoneMessage(new Contact("Nick", 2), "Test Message3", DateTime.Now);

            MessageStorage storage = new MessageStorage();
            storage.AddMessage(testMessage1);
            storage.AddMessage(testMessage2);
            storage.AddMessage(testMessage3);
            storage.SetViewSettings(new MessagesSettings(0, "Nick 0", "", false, DateTime.Now, false, DateTime.Now, false));
            List<PhoneMessage> contactFilterTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, null, "3", false, DateTime.Now, false, DateTime.Now, false));
            List<PhoneMessage> textFilterTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, null, "", true, DateTime.MaxValue, true, DateTime.MaxValue, false));
            List<PhoneMessage> dateFilterTest = storage.ApplyFilters();

            Assert.AreEqual(testMessage1, contactFilterTest[0]);
            Assert.AreEqual(testMessage3, textFilterTest[0]);
            Assert.AreEqual(testMessage2, dateFilterTest[0]);
        }

        [TestMethod]
        public void ApplyFiltersAndCombined() {
            DateTime date1 = new DateTime(2019, 09, 01);
            DateTime date2 = new DateTime(2019, 09, 02);
            DateTime date3 = new DateTime(2019, 09, 03);

            PhoneMessage testMessage1 = new PhoneMessage(new Contact("Nick", 1), "Test Message51", date1);
            PhoneMessage testMessage2 = new PhoneMessage(new Contact("Nick", 2), "Test Message62", date2);
            PhoneMessage testMessage3 = new PhoneMessage(new Contact("Nick", 3), "Test Message73", date3);
            PhoneMessage testMessage4 = new PhoneMessage(new Contact("Nick", 1), "Test Message82", DateTime.MinValue);
            PhoneMessage testMessage5 = new PhoneMessage(new Contact("Nick", 1), "Test Message94", date3);
            PhoneMessage testMessage6 = new PhoneMessage(new Contact("Nick", 4), "Test Message02", date3);
            PhoneMessage testMessage7 = new PhoneMessage(new Contact("Nick", 1), "Test Message552", date3);

            MessageStorage storage = new MessageStorage();
            storage.AddMessage(testMessage1);
            storage.AddMessage(testMessage2);
            storage.AddMessage(testMessage3);
            storage.AddMessage(testMessage4);
            storage.AddMessage(testMessage5);
            storage.AddMessage(testMessage6);
            storage.AddMessage(testMessage7);
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "2", false, DateTime.Now, false, DateTime.Now, true));
            List<PhoneMessage> contactTextTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "", true, date3, true, date3, true));
            List<PhoneMessage> contactDateTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, null, "2", true, date3, true, date3, true));
            List<PhoneMessage> textDateTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "2", true, date3, true, date3, true));
            List<PhoneMessage> allFilterTest = storage.ApplyFilters();

            Assert.AreEqual(testMessage4, contactTextTest[0]);
            Assert.AreEqual(testMessage5, contactDateTest[0]);
            Assert.AreEqual(testMessage6, textDateTest[0]);
            Assert.AreEqual(testMessage7, allFilterTest[0]);
        }

        [TestMethod]
        public void ApplyFiltersOrCombined() {
            DateTime date1 = new DateTime(2019, 09, 01);
            DateTime date2 = new DateTime(2019, 09, 02);
            DateTime date3 = new DateTime(2019, 09, 03);

            PhoneMessage testMessage1 = new PhoneMessage(new Contact("Nick", 1), "Test Message1", date1);
            PhoneMessage testMessage2 = new PhoneMessage(new Contact("Nick", 2), "Test Message2", date2);
            PhoneMessage testMessage3 = new PhoneMessage(new Contact("Nick", 3), "Test Message3", date3);

            MessageStorage storage = new MessageStorage();
            storage.AddMessage(testMessage1);
            storage.AddMessage(testMessage2);
            storage.AddMessage(testMessage3);
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "2", false, DateTime.Now, false, DateTime.Now, false));
            List<PhoneMessage> contactTextTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "", true, date3, true, date3, false));
            List<PhoneMessage> contactDateTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, null, "2", true, date3, true, date3, false));
            List<PhoneMessage> textDateTest = storage.ApplyFilters();
            storage.SetViewSettings(new MessagesSettings(0, "Nick 1", "2", true, date3, true, date3, false));
            List<PhoneMessage> allFilterTest = storage.ApplyFilters();

            Assert.AreEqual(testMessage1, contactTextTest[0]);
            Assert.AreEqual(testMessage2, contactTextTest[1]);
            Assert.AreEqual(testMessage1, contactDateTest[0]);
            Assert.AreEqual(testMessage3, contactDateTest[1]);
            Assert.AreEqual(testMessage2, textDateTest[0]);
            Assert.AreEqual(testMessage3, textDateTest[1]);
            Assert.AreEqual(testMessage1, allFilterTest[0]);
            Assert.AreEqual(testMessage2, allFilterTest[1]);
            Assert.AreEqual(testMessage3, allFilterTest[2]);
        }
    }
}
