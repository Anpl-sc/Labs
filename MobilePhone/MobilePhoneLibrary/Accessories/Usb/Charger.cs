namespace MobilePhoneLibrary.Accessories.Usb {
    public class Charger : IUsb {
        private IUserInOut userInOut;

        public Charger(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(Charger)} connected to USB, charging mobile device");
        }

        public override string ToString() {
            return $"{nameof(Charger)}";
        }
    }
}
