using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Hardware.Screen {
    public class Screen{
        private IUserInOut userInOut;

        public int Height { get; }
        public int Width { get; }
        public ScreenType Type { get; }

        protected Screen(int height, int width, ScreenType type, IUserInOut userInOut) {
            Height = height;
            Width = width;
            Type = type;
            this.userInOut = userInOut;
        }

        public void Show(IScreenImage image) {
            userInOut.WriteLine("Image on " + Type + " display\n");
        }

        public override string ToString() {
            return "Mobile display, Height " + Height + ", Width " + Width + ", Screen Type " + Type;
        }
    }
}
