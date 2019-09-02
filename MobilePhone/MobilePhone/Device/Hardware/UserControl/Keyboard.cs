using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.UserControl {
    class Keyboard : UserControl {
        public int ButtonsNumber { get; }

        public Keyboard(int height, int width, int buttonsNumber) : base(height, width) {
            ButtonsNumber = buttonsNumber;
        }

        public override void ParseInput(IUserInput userInput) {
            Console.WriteLine("User input on keyboard\n");
        }

        public override string ToString() {
            return "Mobile device keyboard, Height " + Height + ", Width " + Width + ", ButtonsNumber " + ButtonsNumber;
        }
    }
}
