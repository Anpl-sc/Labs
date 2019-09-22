using System;

namespace MobilePhoneLibrary.Services.SMS {
    public class PhoneMessage {
        public Contact UserContact { get; }
        public string Text { get; }
        public string FormatText { get; internal set; }
        public DateTime ReceiveDateTime { get; }

        public PhoneMessage(Contact userContact, string text, DateTime receiveDateTime) {
            UserContact = userContact;
            Text = text;
            FormatText = text;
            ReceiveDateTime = receiveDateTime;
        }
    }
}
