using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    class ELincScreen : Screen {
        public ELincScreen(int height, int width, int diagonalSize) : base(height, width, diagonalSize) {
        }

        public override void Show(IScreenImage screenImage) {
            Console.WriteLine("Image on eLink display\n");
        }

        public override string ToString() {
            return "eLink display, Height " + Height + ", Width " + Width + ", DiagonalSize " + DiagonalSize;
        }
    }
}
