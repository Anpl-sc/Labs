using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    public abstract class Screen{
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int DiagonalSize { get; private set; }

        protected Screen(int height, int width, int diagonalSize) {
            Height = height;
            Width = width;
            DiagonalSize = diagonalSize;
        }

        public abstract void Show(IScreenImage image);
    }
}
