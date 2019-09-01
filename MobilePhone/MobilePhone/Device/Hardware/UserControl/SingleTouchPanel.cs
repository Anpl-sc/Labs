using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.UserControl {
    class SingleTouchPanel : TouchPanel {
        public SingleTouchPanel(int height, int width, int sensitivityRate) : base(height, width, sensitivityRate) { }

        public override void ParseInput(IUserInput userInput) {
            Console.WriteLine("User input on single touch panel\n");
        }

        public override void ParseInput(IUserInput userInput, int sensitivity) {
            Console.WriteLine("User input on single touch panel, sensitivity " + sensitivity + "\n");
        }

        public override string ToString() {
            return "Single touch panel, Height " + Height + ", Width " + Width + ", SensitivityRate " + SensitivityRate;
        }
    }
}
