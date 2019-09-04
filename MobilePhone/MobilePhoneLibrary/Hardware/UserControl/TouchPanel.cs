namespace MobilePhoneLibrary.Hardware.UserControl {
    public abstract class TouchPanel : UserControl {
        public int SensitivityRate { get; }

        protected TouchPanel(int height, int width, int sensitivityRate) : base(height, width)
        {
            SensitivityRate = sensitivityRate;
        }

        public abstract void ParseInput(IUserInput userInput, int sensitivity);
    }
}
