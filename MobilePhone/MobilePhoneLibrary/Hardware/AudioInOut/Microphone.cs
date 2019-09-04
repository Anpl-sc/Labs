namespace MobilePhoneLibrary.Hardware.AudioInOut {
    public class Microphone{
        private IUserInOut userInOut;

        public int SensitivityRate { get; }
        public string Bandwidth { get; }

        public Microphone(int sensitivityRate, string bandwidth, IUserInOut userInOut) {
            SensitivityRate = sensitivityRate;
            Bandwidth = bandwidth;
            this.userInOut = userInOut;
        }

        public void TransmitSound(ISound sound) {
            userInOut.WriteLine("Transmit sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public void RecordSound(ISound sound) {
            userInOut.WriteLine("Record sound with Bit Rate " + sound.BitRate + ", and Pitch " + sound.Pitch + "\n");
        }

        public override string ToString() {
            return "Microphone, SensitivityRate " + SensitivityRate + ", Bandwidth " + Bandwidth;
        }
    }
}
