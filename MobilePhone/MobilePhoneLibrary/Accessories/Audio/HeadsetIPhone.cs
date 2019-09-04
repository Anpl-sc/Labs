namespace MobilePhoneLibrary.Accessories.Audio {
    public class HeadsetIPhone : IAudioInOut {
        private IUserInOut userInOut;

        public bool IsButtonPressed { get; set; } = false;

        public HeadsetIPhone(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(HeadsetIPhone)} sound");
        }

        public object Record() {
            return $"{nameof(HeadsetIPhone)} recording";
        }

        public override string ToString() {
            return $"{nameof(HeadsetIPhone)}";
        }
    }
}
