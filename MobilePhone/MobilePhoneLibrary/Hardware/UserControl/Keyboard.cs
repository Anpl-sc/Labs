namespace MobilePhoneLibrary.Hardware.UserControl {
    public class Keyboard : UserControl {
        private IUserInOut userInOut;

        public int ButtonsNumber { get; }

        public Keyboard(int height, int width, int buttonsNumber, IUserInOut userInOut) : base(height, width) {
            ButtonsNumber = buttonsNumber;
            this.userInOut = userInOut;
        }

        public override void ParseInput(IUserInput userInput) {
            userInOut.WriteLine("User input on keyboard\n");
        }

        public override string ToString() {
            return "Mobile device keyboard, Height " + Height + ", Width " + Width + ", ButtonsNumber " + ButtonsNumber;
        }
    }
}
