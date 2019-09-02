using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Device.Hardware.AudioInOut;
using MobilePhone.Device.Hardware.Battery;
using MobilePhone.Device.Hardware.CellularModule;
using MobilePhone.Device.Hardware.Screen;
using MobilePhone.Device.Hardware.UserControl;

namespace MobilePhone.Device {
    public class SimCorpMobile : Mobile {
        public SimCorpMobile() {
            int micSensitivityRate = 70;
            string micBandwidth = "40 - 20k Hz";
            vMicrophone = new Microphone(micSensitivityRate, micBandwidth);

            int outputPower = 50;
            string speakerBandwidth = "20 - 18k Hz";
            vSpeaker = new Speaker(outputPower, speakerBandwidth);

            int capacity = 5000;
            int chargingTime = 60;
            vBattery = new Battery(capacity, chargingTime);

            CellularType cellModuleType = CellularType.Lte;
            int workingDistance = 1000;
            vCellModule = new CellularModule(cellModuleType, workingDistance);

            int screenHeight = 1920;
            int screenWidth = 1080;
            ScreenType screenType = ScreenType.Lcd;
            int brightness = 73;
            int contrast = 57;
            IScreenProfile screenProfile = new BasicScreenProfile(brightness, contrast);
            vScreen = new TuningScreen(screenHeight, screenWidth, screenType, screenProfile);

            int controlHeght = 140;
            int controlWidth = 68;
            int touchSensitivityRate = 90;
            vMultiTouchPanel = new MultiTouchPanel(controlHeght, controlWidth, touchSensitivityRate);
        }

        private readonly Microphone vMicrophone;
        private readonly Speaker vSpeaker;
        private readonly Battery vBattery;
        private readonly CellularModule vCellModule;
        private readonly TuningScreen vScreen;
        private readonly UserControl vMultiTouchPanel;

        public override Microphone Microphone { get { return vMicrophone; } }
        public override Speaker Speaker { get { return vSpeaker; } }
        public override Battery Battery { get { return vBattery; } }
        public override CellularModule CellModule { get { return vCellModule; } }
        public override Screen Screen { get { return vScreen; } }
        public override UserControl Control { get { return vMultiTouchPanel; } }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("Mobile Device Type: SimCorp Mobile\n" + base.ToString());
            return descriptionBuilder.ToString();
        }
    }
}
