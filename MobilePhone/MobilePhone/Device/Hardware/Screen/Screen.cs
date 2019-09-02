using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    public class Screen{
        public int Height { get; }
        public int Width { get; }
        public ScreenType Type { get; }

        protected Screen(int height, int width, ScreenType type) {
            Height = height;
            Width = width;
            Type = type;
        }

        public void Show(IScreenImage image) {
            Console.WriteLine("Image on " + Type + " display\n");
        }

        public override string ToString() {
            return "Mobile display, Height " + Height + ", Width " + Width + ", Screen Type " + Type;
        }
    }
}
