using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Audio {
    class NoNameHeadset : IAudioInOut {
        public void Play(object data) {
            Console.WriteLine($"{nameof(NoNameHeadset)} sound");
        }

        public object Record() {
            return $"{nameof(NoNameHeadset)} recording";
        }

        public override string ToString() {
            return $"{nameof(NoNameHeadset)}";
        }
    }
}
