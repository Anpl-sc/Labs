using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Usb {
    class FlashLight : IUsb {
        private IUserInOut userInOut;

        public FlashLight(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(FlashLight)} connected to USB, consuming power");
        }

        public override string ToString() {
            return $"{nameof(FlashLight)}";
        }
    }
}
