namespace MobilePhoneLibrary.Accessories.Audio {
    public class PortableSpeaker : IAudio {
        private IUserInOut userInOut;

        public int Volume { get; set; } = 0;

        public PortableSpeaker(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(PortableSpeaker)} sound, Volume " + Volume);
        }

        public override string ToString() {
            return $"{nameof(PortableSpeaker)}";
        }
    }
}
