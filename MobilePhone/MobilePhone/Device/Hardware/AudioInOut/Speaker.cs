using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.AudioInOut {
    public class Speaker{
        public int OutputPower { get; private set; }
        public string Bandwidth { get; private set; }

        public Speaker(int outputPower, string bandwidth) {
            OutputPower = outputPower;
            Bandwidth = bandwidth;
        }

        public void PlaySound(ISound sound) {
            Console.WriteLine("Playing sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public override string ToString() {
            return "Speaker, OutputPower " + OutputPower + ", Bandwidth " + Bandwidth;
        }
    }
}
