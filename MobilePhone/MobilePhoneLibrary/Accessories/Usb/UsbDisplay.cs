namespace MobilePhoneLibrary.Accessories.Usb {
    public class UsbDisplay : IDataDeice {
        private IUserInOut userInOut;

        public UsbDisplay(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public void PowerSupply(object data) {
            userInOut.WriteLine($"{nameof(UsbDisplay)} connected to USB, consuming power");
        }

        public void DataTransfer(object data) {
            userInOut.WriteLine($"Send data to {nameof(UsbDisplay)}");
        }

        public override string ToString() {
            return $"{nameof(UsbDisplay)}";
        }
    }
}
