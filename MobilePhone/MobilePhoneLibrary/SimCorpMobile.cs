using System.Text;
using MobilePhoneLibrary.Hardware.AudioInOut;
using MobilePhoneLibrary.Hardware.Battery;
using MobilePhoneLibrary.Hardware.CellularModule;
using MobilePhoneLibrary.Hardware.Screen;
using MobilePhoneLibrary.Hardware.UserControl;
using MobilePhoneLibrary.Services;

namespace MobilePhoneLibrary {
    public class SimCorpMobile : Mobile {
        public SimCorpMobile(IUserInOut userInOut) : base(userInOut) {
            int micSensitivityRate = 70;
            string micBandwidth = "40 - 20k Hz";
            vMicrophone = new Microphone(micSensitivityRate, micBandwidth, userInOut);

            int outputPower = 50;
            string speakerBandwidth = "20 - 18k Hz";
            vSpeaker = new Speaker(outputPower, speakerBandwidth, userInOut);

            int capacity = 5000;
            int chargingTime = 60;
            vBattery = new Battery(capacity, chargingTime, userInOut);

            CellularType cellModuleType = CellularType.Lte;
            int workingDistance = 1000;
            vCellModule = new CellularModule(cellModuleType, workingDistance, userInOut);

            int screenHeight = 1920;
            int screenWidth = 1080;
            ScreenType screenType = ScreenType.Lcd;
            int brightness = 73;
            int contrast = 57;
            IScreenProfile screenProfile = new BasicScreenProfile(brightness, contrast);
            vScreen = new TuningScreen(screenHeight, screenWidth, screenType, screenProfile, userInOut);

            int controlHeght = 140;
            int controlWidth = 68;
            int touchSensitivityRate = 90;
            vMultiTouchPanel = new MultiTouchPanel(controlHeght, controlWidth, touchSensitivityRate, userInOut);

            vSMService = new SMService(); 
        }

        private readonly Microphone vMicrophone;
        private readonly Speaker vSpeaker;
        private readonly Battery vBattery;
        private readonly CellularModule vCellModule;
        private readonly TuningScreen vScreen;
        private readonly UserControl vMultiTouchPanel;
        private readonly SMService vSMService;

        public override Microphone Microphone { get { return vMicrophone; } }
        public override Speaker Speaker { get { return vSpeaker; } }
        public override Battery Battery { get { return vBattery; } }
        public override CellularModule CellModule { get { return vCellModule; } }
        public override Screen Screen { get { return vScreen; } }
        public override UserControl Control { get { return vMultiTouchPanel; } }
        public override SMService MessageService { get { return vSMService; } }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("Mobile Device Type: SimCorp Mobile\r\n" + base.ToString());
            return descriptionBuilder.ToString();
        }
    }
}
