namespace MobilePhoneLibrary.Hardware.Screen {
    public class BasicScreenProfile : IScreenProfile {
        public int Brightness { get; set; }
        public int Contrast { get; set; }

        public BasicScreenProfile(int brightness, int contrast)
        {
            Brightness = brightness;
            Contrast = contrast;
        }
    }
}
