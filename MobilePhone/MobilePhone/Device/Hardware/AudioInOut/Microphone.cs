using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.AudioInOut {
    public class Microphone{
        public int SensitivityRate { get; private set; }
        public string Bandwidth { get; private set; }

        public Microphone(int sensitivityRate, string bandwidth) {
            SensitivityRate = sensitivityRate;
            Bandwidth = bandwidth;
        }

        public void TransmitSound(ISound sound) {
            Console.WriteLine("Transmit sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public void RecordSound(ISound sound) {
            Console.WriteLine("Record sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public override string ToString() {
            return "Microphone, SensitivityRate " + SensitivityRate + ", Bandwidth " + Bandwidth;
        }
    }
}
