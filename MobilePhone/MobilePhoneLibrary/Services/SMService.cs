using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
    public class SMService {
        private delegate string FormatDelegate(string text);
        private FormatDelegate Formatter;
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSReceived;

        public void ReceiveMessage(string message) {
            message = Formatter?.Invoke(message) ?? message;
            SMSReceived?.Invoke(message);
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

        private static string FormatWithDateStart(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        private static string FormatWithDateEnd(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        private static string FormatWithLowerCase(string message) {
            return message.ToLower();
        }

        private static string FormatWithUpperCase(string message) {
            return message.ToUpper();
        }

        private static string FormatWithTime(string message) {
            return $"{DateTime.Now.ToString("HH:mm:ss")}: {message}";
        }
    }
}
