using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
    public class SMSProvider {
        private int messageCounter;

        public PhoneMessage GetMessage(List<Contact> contacts) {
            messageCounter++;
            int userIx = new Random().Next(contacts.Count);
            string text = "Some Message #" + messageCounter;
            PhoneMessage message = new PhoneMessage(contacts.ElementAt(userIx), text, DateTime.Now);
            return message;
        }
    }
}
