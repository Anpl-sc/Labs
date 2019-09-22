using System.Collections.Generic;
using System.Threading;

namespace MobilePhoneLibrary.Services.SMS {
    public class SMSProviderThread : SMSProvider {
        public override void Start(List<Contact> contacts) {
            CanCreateMessage = true;
            Thread messageThread = new Thread(() => {
                while (CanCreateMessage) {
                    Thread.Sleep(500);
                    Generate?.Invoke(this, GetMessage(contacts));
                }
            });

            messageThread.Start();
        }
    }
}
