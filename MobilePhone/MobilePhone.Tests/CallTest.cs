using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneLibrary.Services.Calls;

namespace MobilePhone.Tests {
    [TestClass]
    public class CallTest {
        [TestMethod]
        public void CompareToAddItem() {
            List<CallContact> contacts = new List<CallContact> {
                new CallContact("John", new List<int> { 380101, 380102 }),
                new CallContact("Nick", new List<int> { 380201 }),
                new CallContact("Emma", new List<int> { 380301, 380302, 380303 })
            };

            DateTime date1 = new DateTime(2019, 09, 01);
            DateTime date2 = new DateTime(2019, 09, 02);            

            Call call1 = new Call(contacts[0], contacts[0].PhoneNumbers[0], date1, Direction.Incoming);
            Call call2 = new Call(contacts[2], contacts[2].PhoneNumbers[0], date1, Direction.Incoming);
            Call call3 = new Call(contacts[1], contacts[1].PhoneNumbers[0], date2, Direction.Incoming);

            List<Call> calls = new List<Call> {call1, call2, call3};

            List<Call> callsSort = calls.OrderByDescending(c => c).ToList();

            Assert.IsTrue(callsSort[0].Equals(call3) 
                && callsSort[1].Equals(call1) 
                && callsSort[2].Equals(call2));
        }

        [TestMethod]
        public void CompareToRemoveItem() {
            List<CallContact> contacts = new List<CallContact> {
                new CallContact("John", new List<int> { 380101, 380102 }),
                new CallContact("Nick", new List<int> { 380201 }),
                new CallContact("Emma", new List<int> { 380301, 380302, 380303 })
            };

            DateTime date1 = new DateTime(2019, 09, 01);
            DateTime date2 = new DateTime(2019, 09, 02);

            Call call1 = new Call(contacts[0], contacts[0].PhoneNumbers[0], date1, Direction.Incoming);
            Call call2 = new Call(contacts[2], contacts[2].PhoneNumbers[0], date1, Direction.Incoming);
            Call call3 = new Call(contacts[1], contacts[1].PhoneNumbers[0], date2, Direction.Incoming);

            List<Call> calls = new List<Call> { call1, call2, call3 };

            List<Call> callsSort = calls.OrderByDescending(c => c).ToList();
            callsSort.Remove(call3);
            List<Call> callsRemoveSort = callsSort.OrderByDescending(c => c).ToList();

            Assert.IsTrue(callsRemoveSort[0].Equals(call1)
                && callsRemoveSort[1].Equals(call2));
        }

        [TestMethod]
        public void EqualsSimilar() {
            CallContact contact1 = new CallContact("John", new List<int> {380101, 380102});

            DateTime date1 = new DateTime(2019, 09, 01);
            DateTime date2 = new DateTime(2019, 09, 02);

            Call call1 = new Call(contact1, contact1.PhoneNumbers[0], date1, Direction.Incoming);
            Call call2 = new Call(contact1, contact1.PhoneNumbers[1], date2, Direction.Incoming);

            Assert.IsTrue(call1.Equals(call2));
        }

        [TestMethod]
        public void EqualsDifferentDirection() {
            CallContact contact1 = new CallContact("John", new List<int> { 380101, 380102 });

            DateTime date1 = new DateTime(2019, 09, 01);

            Call call1 = new Call(contact1, contact1.PhoneNumbers[0], date1, Direction.Incoming);
            Call call2 = new Call(contact1, contact1.PhoneNumbers[0], date1, Direction.Outgoing);

            Assert.IsFalse(call1.Equals(call2));
        }

        [TestMethod]
        public void EqualsDifferentContact() {
            CallContact contact1 = new CallContact("John", new List<int> { 380101, 380102 });
            CallContact contact2 = new CallContact("Nick", new List<int> { 380101 });

            DateTime date1 = new DateTime(2019, 09, 01);

            Call call1 = new Call(contact1, contact1.PhoneNumbers[0], date1, Direction.Incoming);
            Call call2 = new Call(contact2, contact2.PhoneNumbers[0], date1, Direction.Incoming);

            Assert.IsFalse(call1.Equals(call2));
        }
    }
}
