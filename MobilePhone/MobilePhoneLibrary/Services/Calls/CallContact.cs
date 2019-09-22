using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services.Calls {
    public class CallContact : IComparable<CallContact> {
        public string Name { get; }
        public List<int> PhoneNumbers { get; }

        public CallContact(string name, List<int> phoneNumbers) {
            Name = name;
            PhoneNumbers = phoneNumbers;
        }

        public int CompareTo(CallContact otherContact) {
            return string.Compare(Name, otherContact.Name, StringComparison.Ordinal);
        }
    }
}
