using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Hardware.AudioInOut {
    public class Speaker{
        private IUserInOut userInOut;

        public int OutputPower { get; }
        public string Bandwidth { get; }

        public Speaker(int outputPower, string bandwidth, IUserInOut userInOut) {
            OutputPower = outputPower;
            Bandwidth = bandwidth;
            this.userInOut = userInOut;
        }

        public void PlaySound(ISound sound) {
            userInOut.WriteLine("Playing sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public override string ToString() {
            return "Speaker, OutputPower " + OutputPower + ", Bandwidth " + Bandwidth;
        }
    }
}
