using System.Collections.Generic;
using System.Text;
using MobilePhoneLibrary.Hardware.AudioInOut;
using MobilePhoneLibrary.Hardware.Battery;
using MobilePhoneLibrary.Hardware.CellularModule;
using MobilePhoneLibrary.Hardware.Screen;
using MobilePhoneLibrary.Hardware.UserControl;
using MobilePhoneLibrary.Services;
using MobilePhoneLibrary.Services.SMS;

namespace MobilePhoneLibrary {
    public class SimCorpMobile : Mobile {
        public SimCorpMobile(IUserInOut userInOut) : base(userInOut) {
            int micSensitivityRate = 70;
            string micBandwidth = "40 - 20k Hz";
            vMicrophone = new Microphone(micSensitivityRate, micBandwidth, userInOut);

            int outputPower = 50;
            string speakerBandwidth = "20 - 18k Hz";
            vSpeaker = new Speaker(outputPower, speakerBandwidth, userInOut);

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

            vMessageStorage = new MessageStorage {
                Contacts = new List<Contact> {
                    new Contact("John", 380101),
                    new Contact("Nick", 380102),
                    new Contact("Emma", 380103)
                }
            };

            ParallelType type = ParallelType.Task;
            vSMSProvider = GetSMSProvider(type);
            vBattery = GetBattery(type, userInOut);
        }

        private SMSProvider GetSMSProvider(ParallelType type) {
            SMSProvider provider;
            if (type.Equals(ParallelType.Thread)) {
                provider = new SMSProviderThread(); 
            } else {
                provider = new SMSProviderTask();
            }
            return provider;
        }

        private Battery GetBattery(ParallelType type, IUserInOut userInOut) {
            Battery battery;
            int capacity = 5000;
            int chargingTime = 60;

            if (type.Equals(ParallelType.Thread)) {   
                battery = new BatteryThread(capacity, chargingTime, userInOut);
            } else { 
                battery = new BatteryTask(capacity, chargingTime, userInOut); 
            }
            return battery;
        }

        private readonly Microphone vMicrophone;
        private readonly Speaker vSpeaker;
        private readonly Battery vBattery;
        private readonly CellularModule vCellModule;
        private readonly TuningScreen vScreen;
        private readonly UserControl vMultiTouchPanel;
        private readonly MessageStorage vMessageStorage;
        private readonly SMSProvider vSMSProvider;

        public override Microphone Microphone { get { return vMicrophone; } }
        public override Speaker Speaker { get { return vSpeaker; } }
        public override Battery Battery { get { return vBattery; } }
        public override CellularModule CellModule { get { return vCellModule; } }
        public override Screen Screen { get { return vScreen; } }
        public override UserControl Control { get { return vMultiTouchPanel; } }
        public override MessageStorage MessageStorage { get { return vMessageStorage; } }
        internal override SMSProvider SMSProvider { get { return vSMSProvider; } }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine("Mobile Device Type: SimCorp Mobile\r\n" + base.ToString());
            return descriptionBuilder.ToString();
        }
    }
}
