using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Audio {
    class NoNameHeadset : IAudioInOut {
        private IUserInOut userInOut;

        public NoNameHeadset(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(NoNameHeadset)} sound");
        }

        public object Record() {
            return $"{nameof(NoNameHeadset)} recording";
        }

        public override string ToString() {
            return $"{nameof(NoNameHeadset)}";
        }
    }
}
