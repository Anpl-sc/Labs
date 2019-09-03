using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Audio {
    class HeadsetIPhone : IAudioInOut {
        private IUserInOut userInOut;

        public bool IsButtonPressed { get; set; } = false;

        public HeadsetIPhone(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(HeadsetIPhone)} sound");
        }

        public object Record() {
            return $"{nameof(HeadsetIPhone)} recording";
        }

        public override string ToString() {
            return $"{nameof(HeadsetIPhone)}";
        }
    }
}
