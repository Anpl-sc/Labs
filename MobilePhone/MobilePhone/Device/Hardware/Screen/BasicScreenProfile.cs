using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    class BasicScreenProfile : IScreenProfile {
        public int Brightness { get; set; }
        public int Contrast { get; set; }

        public BasicScreenProfile(int brightness, int contrast)
        {
            Brightness = brightness;
            Contrast = contrast;
        }
    }
}
