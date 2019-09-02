using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.Screen {
    public class TuningScreen : Screen {
        public IScreenProfile CurrentProfile { get; }

        public TuningScreen(int height, int width, ScreenType type, IScreenProfile profile ) : base(height, width, type) {
            CurrentProfile = profile;
        }

        public void Show(IScreenImage image, IScreenProfile profile) {
            Console.WriteLine("Image on " + Type + " display with brightness " + profile.Brightness + ", and contrast " + profile.Contrast + "\n");
        }

        public override string ToString() {
            return $"{base.ToString()}, Brightness " + CurrentProfile.Brightness + ", Contrast " + CurrentProfile.Contrast;
        }
    }
}
