using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Accessories.Audio {
    class SamsungHeadphones : IAudio {
        public int SoundImprovingRate { get; }

        public SamsungHeadphones(int soundImprovingRate) {
            SoundImprovingRate = soundImprovingRate;
        }

        public void Play(object data) {
            Console.WriteLine($"{nameof(SamsungHeadphones)} sound");
        }

        public override string ToString() {
            return $"{nameof(SamsungHeadphones)}";
        }
    }
}
