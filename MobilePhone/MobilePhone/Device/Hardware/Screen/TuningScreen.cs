using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Hardware.Screen {
    public class TuningScreen : Screen {
        private IUserInOut userInOut;

        public IScreenProfile CurrentProfile { get; }

        public TuningScreen(int height, int width, ScreenType type, IScreenProfile profile, IUserInOut userInOut) : base(height, width, type, userInOut)
        {
            CurrentProfile = profile;
            this.userInOut = userInOut;
        }

        public void Show(IScreenImage image, IScreenProfile profile) {
            userInOut.WriteLine("Image on " + Type + " display with brightness " + profile.Brightness + ", and contrast " + profile.Contrast + "\n");
        }

        public override string ToString() {
            return $"{base.ToString()}, Brightness " + CurrentProfile.Brightness + ", Contrast " + CurrentProfile.Contrast;
        }
    }
}
