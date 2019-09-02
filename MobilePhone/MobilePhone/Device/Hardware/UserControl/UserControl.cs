using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.UserControl {
    public abstract class UserControl{
        public int Height { get; }
        public int Width { get; }

        protected UserControl(int height, int width) {
            Height = height;
            Width = width;
        }

        public abstract void ParseInput(IUserInput userInput);
    }
}
