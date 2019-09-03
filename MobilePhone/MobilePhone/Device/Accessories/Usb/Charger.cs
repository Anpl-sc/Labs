using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Usb {
    class Charger : IUsb {
        public void PowerSupply(object data) {
            Console.WriteLine($"{nameof(Charger)} connected to USB, charging mobile device");
        }

        public override string ToString() {
            return $"{nameof(Charger)}";
        }
    }
}
