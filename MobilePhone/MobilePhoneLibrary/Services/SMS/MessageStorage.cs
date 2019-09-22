using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhoneLibrary.Services.SMS {
    public class MessageStorage {
        private delegate string FormatDelegate(PhoneMessage message);
        private FormatDelegate Formatter;
        public delegate void SMSShowDelegate(List<PhoneMessage> messages);
        public event SMSShowDelegate SMSShow;
        public delegate void SMSNotifyDelegate(string notify);
        public event SMSNotifyDelegate SMSNotify;

        private List<PhoneMessage> messages = new List<PhoneMessage>();
        private MessagesSettings settings;
        public List<Contact> Contacts { get; set; }

        public void AddMessage(PhoneMessage message) {
            messages.Add(message);
            SMSNotify?.Invoke($"New message has been received from {message.UserContact.GetContact()}");
            ShowPhoneMessages();
        }

        public List<PhoneMessage> GetMessages() {
            return messages;
        }

        public void Remove(PhoneMessage message) {
            messages.Remove(message);
            SMSNotify?.Invoke($"Message from {message.UserContact.GetContact()} was deleted");
            ShowPhoneMessages();
        }

        public void ShowPhoneMessages() {
            if (messages.Count != 0) {
                List<PhoneMessage> filteredMessages = ApplyFilters();
                SMSShow?.Invoke(filteredMessages);
            }
        }

        public void SetViewSettings(MessagesSettings messagesSettings) {
            settings = messagesSettings;
            ShowPhoneMessages();
        }

        public List<PhoneMessage> ApplyFilters() {
            if (settings != null) {
                Func<bool?, bool?, bool?, bool> combine =
                    (b1, b2, b3) => ((b1 ?? b2 ?? b3) == null) || (b1 ?? false) || (b2 ?? false) || (b3 ?? false);

                if (settings.AndCombined) {
                    combine = (b1, b2, b3) => (b1 ?? true) && (b2 ?? true) && (b3 ?? true);
                }

                List<PhoneMessage> filterMessages = 
                    (from message in messages
                    where combine(settings.ContactSelected?.ToString().Equals(message.UserContact.GetContact()),
                        string.IsNullOrWhiteSpace(settings.TextSearch)
                            ? (bool?) null
                            : message.Text.Contains(settings.TextSearch),
                        settings.IsFrom || settings.IsTo
                            ? (!settings.IsFrom || message.ReceiveDateTime >= settings.FromDate)
                              && (!settings.IsTo || message.ReceiveDateTime <= settings.ToDate)
                            : (bool?) null)
                    select message).ToList();

                SetFormatting(settings.FormatNumber);
                foreach (var message in filterMessages) {
                    message.FormatText = Formatter?.Invoke(message) ?? message.Text;
                }

                return filterMessages;
            }

            return messages;
        }

        public void SetFormatting(int formatNumber) {
            if (formatNumber >= 0 && formatNumber <= 5) {
                switch (formatNumber) {
                    case 0:
                        Formatter = null;
                        break;
                    case 1:
                        Formatter = FormatWithDateStart;
                        break;
                    case 2:
                        Formatter = FormatWithDateEnd;
                        break;
                    case 3:
                        Formatter = FormatWithLowerCase;
                        break;
                    case 4:
                        Formatter = FormatWithUpperCase;
                        break;
                    case 5:
                        Formatter = FormatWithTime;
                        break;
                }
            }
        }

        private static string FormatWithDateStart(PhoneMessage message) {
            return $"[{message.ReceiveDateTime}] {message.Text}";
        }

        private static string FormatWithDateEnd(PhoneMessage message) {
            return $"{message.Text} [{message.ReceiveDateTime}]";
        }

        private static string FormatWithLowerCase(PhoneMessage message) {
            return message.Text.ToLower();
        }

        private static string FormatWithUpperCase(PhoneMessage message) {
            return message.Text.ToUpper();
        }

        private static string FormatWithTime(PhoneMessage message) {
            return $"{message.ReceiveDateTime.ToString("HH:mm:ss")}: {message.Text}";
        }
    }
}
