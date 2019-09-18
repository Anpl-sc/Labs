using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
    public class SMSProviderTask : SMSProvider {
        public override void Start(List<Contact> contacts) {
            var messageTask = GetMessageTask(contacts);
        }

        private async Task GetMessageTask(List<Contact> contacts) {
            CanCreateMessage = true;
            while (CanCreateMessage) {
                PhoneMessage message = await Task.Run(async () => {
                    await Task.Delay(500);
                    return GetMessage(contacts);
                });

                Generate?.Invoke(this, message);
            }
        }
    }
}
