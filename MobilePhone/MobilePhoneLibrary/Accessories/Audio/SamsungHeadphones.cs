namespace MobilePhoneLibrary.Accessories.Audio {
    public class SamsungHeadphones : IAudio {
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
