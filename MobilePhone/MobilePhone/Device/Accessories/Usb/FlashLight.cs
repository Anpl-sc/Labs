using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Usb {
    class FlashLight : IUsb {
        public void PowerSupply(object data) {
            Console.WriteLine($"{nameof(FlashLight)} connected to USB, consuming power");
        }

        public override string ToString() {
            return $"{nameof(FlashLight)}";
        }
    }
}
