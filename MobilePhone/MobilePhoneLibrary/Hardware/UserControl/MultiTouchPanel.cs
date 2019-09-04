namespace MobilePhoneLibrary.Hardware.UserControl {
    public class MultiTouchPanel : TouchPanel {
        private IUserInOut userInOut;

        public MultiTouchPanel(int height, int width, int sensitivityRate, IUserInOut userInOut) : base(height, width, sensitivityRate) {
            this.userInOut = userInOut;
        }

        public override void ParseInput(IUserInput userInput) {
            userInOut.WriteLine("User input on multi touch panel\n");
        }

        public override void ParseInput(IUserInput userInput, int sensitivity) {
            userInOut.WriteLine("User input on multi touch panel, sensitivity " + sensitivity + "\n");
        }

        public override string ToString() {
            return "Multi touch panel, Height " + Height + ", Width " + Width + ", SensitivityRate " + SensitivityRate;
        }
    }
}
