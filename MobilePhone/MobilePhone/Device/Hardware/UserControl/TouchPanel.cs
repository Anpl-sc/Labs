using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.UserControl {
    abstract class TouchPanel : UserControl {
        public int SensitivityRate { get; private set; }

        protected TouchPanel(int height, int width, int sensitivityRate) : base(height, width)
        {
            SensitivityRate = sensitivityRate;
        }

        public abstract void ParseInput(IUserInput userInput, int sensitivity);
    }
}
