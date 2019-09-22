using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MobilePhoneLibrary.Services.SMS {
    public class SMSProvider {
        private int messageCounter;
        private volatile bool vCanCreateMessage;

        protected bool CanCreateMessage {
            get { return vCanCreateMessage; }
            set { vCanCreateMessage = value; }
        }

        public EventHandler<PhoneMessage> Generate;

        public virtual void Start(List<Contact> contacts) {
            CanCreateMessage = true;
            while (CanCreateMessage)
            {
                Thread.Sleep(500);
                Generate?.Invoke(this, GetMessage(contacts));
            }
        }
        
        public void Stop() {
            CanCreateMessage = false;
        }

        public PhoneMessage GetMessage(List<Contact> contacts) {
            messageCounter++;
            int userIx = new Random().Next(contacts.Count);
            string text = "Some Message #" + messageCounter;
            PhoneMessage message = new PhoneMessage(contacts.ElementAt(userIx), text, DateTime.Now);
            return message;
        }
    }
}
