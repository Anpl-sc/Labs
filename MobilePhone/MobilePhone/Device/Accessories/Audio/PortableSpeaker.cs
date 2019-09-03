using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Audio {
    class PortableSpeaker : IAudio {
        public int Volume { get; set; } = 0;

        public void Play(object data) {
            Console.WriteLine($"{nameof(PortableSpeaker)} sound, Volume " + Volume);
        }

        public override string ToString() {
            return $"{nameof(PortableSpeaker)}";
        }
    }
}
