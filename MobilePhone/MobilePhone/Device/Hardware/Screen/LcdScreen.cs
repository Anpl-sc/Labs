using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    class LcdScreen : Screen {
        public LcdScreen(int height, int width, int diagonalSize) : base(height, width, diagonalSize) {
        }

        public override void Show(IScreenImage image) {
            Console.WriteLine("Image on LCD display\n");
        }

        public void Show(IScreenImage image, IScreenProfile profile) {
            Console.WriteLine("Image on LCD display with brightness" + profile.Brightness + ", and contrast" + profile.Contrast + "\n");
        }

        public override string ToString() {
            return "LCD display, Height " + Height + ", Width " + Width + ", DiagonalSize " + DiagonalSize;
        }
    }
}
