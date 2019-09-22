using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services.Calls {
    public class CallsProvider {
        private List<Call> calls;
        public List<CallContact> Contacts { get; }

        public EventHandler<List<Call>> Show;

        public CallsProvider() {
            Contacts = new List<CallContact> {
                new CallContact("John", new List<int> { 380101, 380102 }),
                new CallContact("Nick", new List<int> { 380201 }),
                new CallContact("Emma", new List<int> { 380301, 380302, 380303 })
            };
            calls = new List<Call>();

            var callTask = GenerateCalls();            
        }

        public async Task GenerateCalls() {
            while (true) {
                List<Call> newCall = await Task.Run(async () => await GetCall());

                calls.AddRange(newCall);
                calls = calls.OrderByDescending(c => c).ToList();
                Show?.Invoke(this, calls);
            }
        }

        private async Task<List<Call>> GetCall() {
            List<Call> newCalls = new List<Call>();
            CallContact contact = Contacts.ElementAt(new Random().Next(Contacts.Count));
            int numbersMax = Contacts.Select(c => c.PhoneNumbers.Count).Max();

            for (int i = 0; i < numbersMax; i++) {
                await Task.Delay(700);

                int phoneNumber = contact.PhoneNumbers.ElementAt(
                    new Random().Next(contact.PhoneNumbers.Count));
                Direction direction = (Direction) Enum.ToObject(typeof(Direction), 
                    new Random().Next(Enum.GetValues(typeof(Direction)).Length));
                newCalls.Add( new Call(contact, phoneNumber, DateTime.Now, direction ));
            }
            
            return newCalls;
        }

        public List<Call> GetAllCalls() {
            return calls;
        }

        public void RemoveCall(Call call) {
            calls.Remove(call);
            calls = calls.OrderByDescending(c => c).ToList();
            Show?.Invoke(this, calls);
        }
    }
}
