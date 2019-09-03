using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Accessories.Audio {
    class SamsungHeadphones : IAudio {
        private IUserInOut userInOut;

        public int SoundImprovingRate { get; }

        public SamsungHeadphones(int soundImprovingRate, IUserInOut userInOut)
        {
            SoundImprovingRate = soundImprovingRate;
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(SamsungHeadphones)} sound");
        }

        public override string ToString() {
            return $"{nameof(SamsungHeadphones)}";
        }
    }
}
