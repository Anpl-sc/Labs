using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services.Calls {
    public class Call : IComparable<Call> {
        public CallContact Contact { get; }
        public int ContactPhone { get; }
        public DateTime Time { get; }
        public Direction Direction { get; }

        public Call(CallContact contact, int contactPhone, DateTime time, Direction direction) {
            Contact = contact;
            ContactPhone = contactPhone;
            Time = time;
            Direction = direction;
        }

        public int CompareTo(Call otherCall) {
            if (Time != otherCall.Time) {
                return Time.CompareTo(otherCall.Time);
            }
            return Contact.CompareTo(otherCall.Contact);
        }

        public override bool Equals(object obj) {
            Call call = obj as Call;
            return Equals(call);
        }

        private bool Equals(Call other) {
            return Equals(Contact, other.Contact) && Direction == other.Direction;
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = Contact?.GetHashCode() ?? 0;
                hashCode = (hashCode*397) ^ (int) Direction;
                return hashCode;
            }
        }
    }
}
