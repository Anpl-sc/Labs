namespace MobilePhoneLibrary.Accessories.Audio {
    public class NoNameHeadset : IAudioInOut {
        private IUserInOut userInOut;

        public NoNameHeadset(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void Play(object data) {
            userInOut.WriteLine($"{nameof(NoNameHeadset)} sound");
        }

        public object Record() {
            return $"{nameof(NoNameHeadset)} recording";
        }

        public override string ToString() {
            return $"{nameof(NoNameHeadset)}";
        }
    }
}
