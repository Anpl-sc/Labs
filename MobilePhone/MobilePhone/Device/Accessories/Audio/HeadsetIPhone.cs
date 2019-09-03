using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Audio {
    class HeadsetIPhone : IAudioInOut {
        public bool IsButtonPressed { get; set; } = false;

        public void Play(object data) {
            Console.WriteLine($"{nameof(HeadsetIPhone)} sound");
        }

        public object Record() {
            return $"{nameof(HeadsetIPhone)} recording";
        }

        public override string ToString() {
            return $"{nameof(HeadsetIPhone)}";
        }
    }
}
