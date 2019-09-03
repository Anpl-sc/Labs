using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Hardware.UserControl {
    class SingleTouchPanel : TouchPanel {
        private IUserInOut userInOut;

        public SingleTouchPanel(int height, int width, int sensitivityRate, IUserInOut userInOut) : base(height, width, sensitivityRate) {
            this.userInOut = userInOut;
        }

        public override void ParseInput(IUserInput userInput) {
            userInOut.WriteLine("User input on single touch panel\n");
        }

        public override void ParseInput(IUserInput userInput, int sensitivity) {
            userInOut.WriteLine("User input on single touch panel, sensitivity " + sensitivity + "\n");
        }

        public override string ToString() {
            return "Single touch panel, Height " + Height + ", Width " + Width + ", SensitivityRate " + SensitivityRate;
        }
    }
}
