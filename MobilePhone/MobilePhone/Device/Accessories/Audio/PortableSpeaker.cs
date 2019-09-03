using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Audio {
    class PortableSpeaker : IAudio {
        private IUserInOut userInOut;

        public int Volume { get; set; } = 0;

        public PortableSpeaker(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(PortableSpeaker)} sound, Volume " + Volume);
        }

        public override string ToString() {
            return $"{nameof(PortableSpeaker)}";
        }
    }
}
