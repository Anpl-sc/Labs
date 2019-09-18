using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
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
