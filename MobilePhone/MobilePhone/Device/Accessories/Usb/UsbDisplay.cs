using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Usb {
    class UsbDisplay : IDataDeice {
        private IUserInOut userInOut;

        public UsbDisplay(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(UsbDisplay)} connected to USB, consuming power");
        }

        public void DataTransfer(object data) {
            userInOut.WriteLine($"Send data to {nameof(UsbDisplay)}");
        }

        public override string ToString() {
            return $"{nameof(UsbDisplay)}";
        }
    }
}
