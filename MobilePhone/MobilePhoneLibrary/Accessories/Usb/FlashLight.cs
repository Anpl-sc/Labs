namespace MobilePhoneLibrary.Accessories.Usb {
    public class FlashLight : IUsb {
        private IUserInOut userInOut;

        public FlashLight(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(FlashLight)} connected to USB, consuming power");
        }

        public override string ToString() {
            return $"{nameof(FlashLight)}";
        }
    }
}
