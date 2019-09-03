using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Usb {
    class UsbDisplay : IDataDeice {
        public void PowerSupply(object data) {
            Console.WriteLine($"{nameof(UsbDisplay)} connected to USB, consuming power");
        }

        public void DataTransfer(object data) {
            Console.WriteLine($"Send data to {nameof(UsbDisplay)}");
        }

        public override string ToString() {
            return $"{nameof(UsbDisplay)}";
        }
    }
}
