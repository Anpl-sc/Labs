using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Usb {
    class Charger : IUsb {
        private IUserInOut userInOut;

        public Charger(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(Charger)} connected to USB, charging mobile device");
        }

        public override string ToString() {
            return $"{nameof(Charger)}";
        }
    }
}
